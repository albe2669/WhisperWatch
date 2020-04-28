<script>
	// import pixelMeterScale from 'constants.js';
	import simpleheat from 'simpleheat';
	import config from '../config.js';
	import { getData } from '../api.js';
	import { onMount } from 'svelte';
	import { sensors, currentFloor } from '../stores.js';

	let canvas;
	let floor = $currentFloor;
	let rooms = config[floor];
	let imgSrc = `/assets/bygningstegninger/${floor}sal.png`;

	currentFloor.subscribe(newFloor => {
		floor = newFloor;
		rooms = config[floor];
		imgSrc = `/assets/bygningstegninger/${floor}sal.png`;
		console.log(newFloor);
	});

	onMount(async () => {
		const ctx = canvas.getContext('2d');

		ctx.lineWidth = 2;
		ctx.font = '30px Consolas';

		const sclFac = 15;

		function drawPoint(x, y) {
			const tX = (x * sclFac) + 800;
			const tY = (y * sclFac) + 300;

			ctx.fillRect(tX - 10, tY - 10, 20, 20);
		}

		function drawCircle(x, y, radius) {
			const tX = (x * sclFac) + 800;
			const tY = (y * sclFac) + 300;
			const tR = radius * sclFac;

			ctx.beginPath();
			ctx.arc(tX, tY, tR, 0, 2 * Math.PI);
			ctx.stroke();
		}

		function rssiToDist(rssi, n = 3.2) {
			const ptx = -35.5;
			return 10 ** ((ptx - rssi) / (10 * n));
		}

		function avg(...args) {
			return args.reduce((acc, val) => acc + val, 0) / args.length;
		}

		let txtY = 430;
		function textY() {
			txtY += 40;
			return txtY;
		}
		let textX = 1300;

		async function calculateTests() {
			imgSrc = '';

			const sensors = await getData();
			const colours = ['magenta', 'green', 'purple', 'orange'];

			const macs = [...new Set(sensors.flatMap(sens => sens.devices.map(dev => dev.macAddress)))];

			const datapoints = [];

			let str = '';

			const inps = macs.map((mac) => {
				// Vi er kun interesserede i disse MAC-adresser, for det er dem, vi kan kontrollere.
				const whitelist = [
					'30:74:96:E2:26:C3'.toLowerCase(),
					'C4:62:EA:B4:C0:40'.toLowerCase(),
					'48:27:EA:4A:3A:90'.toLowerCase(),
					'88:9B:39:33:DF:CD'.toLowerCase(),
					'00:66:4B:BC:98:E2'.toLowerCase(),
					'40:30:04:9A:4A:93'.toLowerCase(),
				];
				if (!whitelist.includes(mac)) return null;

				const num_conns = sensors.reduce((acc, cur) => {
					return cur.devices.find(dev => dev.macAddress === mac) ? acc + 1 : acc;
				}, 0);

				console.log(num_conns)

				if (num_conns < 3) return null;

				// Find top 3 signal strengths
				const allConnections = sensors
					.map(sens => ({
						sensorId: sens.id,
						device: sens.devices.find(dev => dev.macAddress === mac),
					}))
					.filter(con => con.device !== undefined)
					.map(con => ({
						sensorId: con.sensorId,
						signalStrength: con.device.signalStrength,
					}));

				allConnections.sort((a, b) => b.signalStrength - a.signalStrength);

				const inp =	allConnections
					.slice(0, 3)
					.map((con) => {
						const { x, y } = $sensors.find(({ id }) => id === con.sensorId).location;
						const d = rssiToDist(con.signalStrength);
						
						return [x, y, d];
					});

				return inp;
			}).filter(inp => inp !== null);

			let i = 0;
			function nextDraw() {
				ctx.clearRect(0, 0, canvas.width, canvas.height);
				txtY = 430;

				i++;
				if (i >= inps.length) i = 0;

				const inp = inps[i];

				inp.forEach((dp, j) => {
					ctx.fillStyle = colours[j];
					ctx.strokeStyle = colours[j];

					const [x, y, d] = dp;

					drawPoint(x, y);
					drawCircle(x, y, d);

					ctx.fillText(`Sensor ${j + 1}: ${d.toFixed(2)} meter`, textX, textY());
				});

				const [resX, resY] = trilat(inp);
				ctx.fillStyle = 'blue';
				drawPoint(resX, resY);
				ctx.fillText('Enhedens beregnede position', textX, textY());

				const pX = 10;
				const pY = 20;

				ctx.fillStyle = 'red';
				drawPoint(pX, pY);
				ctx.fillText('Enhedens reelle position', textX, textY());
				
				ctx.fillStyle = 'black';
				const deviation = Math.sqrt((pX - resX) ** 2 + (pY - resY) ** 2);
				ctx.fillText(`Afvigelse: ${deviation.toFixed(2)} meter`, textX, textY());
			}
			setInterval(nextDraw, 250);

			console.log(inps);
		}

		function generateExample() {
			function getRandomBetween(min, max) {
				min = Math.ceil(min);
				max = Math.floor(max);
				return Math.floor(Math.random() * (max - min + 1)) + min;
			}

			const heatmap = simpleheat(canvas);

			heatmap.radius(30, 20);
			heatmap.max(2);

			const heatData = rooms.flatMap((room) => {
				const cX = room.x + room.w / 2;
				const cY = room.y + room.h / 2;

				const numRand = room.area / 5;

				const coords = [];

				for (let i = 0; i < numRand; i++) {
					const x = getRandomBetween(room.x, room.x + room.w);
					const y = getRandomBetween(room.y, room.y + room.h);

					coords.push([x, y, 1]);
				}

				return coords;
			});

			console.log(heatData);

			heatmap.data(heatData);

			heatmap.draw();
		}

		// Her bestemmes hvad der tegnes på <canvas>et. Hvis det er generateExample er det
		// det tilfældige eksempel. Hvis det er calculateTest beregner den vores tests. 
		generateExample();
		// calculateTests();
	});
</script>

<div class="container">
	<h1>{floor}. sal</h1>
	<canvas
		style="background-image: url({imgSrc})"
		bind:this={canvas}
		width={2026} height={1044}
	></canvas>
</div>

<style>
canvas {
	max-height: 80vh;
	background-size: contain;
}

.container {
	padding: 1rem;
	text-align: center;
}
</style>
