import exampleResponse from './api-response-max.json';

export async function getData() {
    const res = await fetch('/api/buildings/1/floors/1/rooms');
    const data = await res.json();

    // const data = exampleResponse;

    return data;

    // return [
    //     // Should be 10m
    //     {
    //         sensorId: 1,
    //         mac: '30:74:96:e2:25:01',
    //         rssi: avg(-49, -51, -53, -57, -52, -55, -64, -63, -52, -62, -54, -53, -62),
    //     },
    //     // Should be 10m
    //     {
    //         sensorId: 2,
    //         mac: '30:74:96:e2:25:01',
    //         rssi: avg(-48, -50, -56, -56, -50, -50, -62, -56, -62, -56, -56, -68, -58),
    //     },
    //     // Should be 11m
    //     {
    //         sensorId: 3,
    //         mac: '30:74:96:e2:25:01',
    //         rssi: avg(-50, -53, -54, -55, -52, -53, -60, -53, -52, -51, -56, -53, -62),
    //     },
    // ]
    // return [
    //     {
    //         sensorId: 1,
    //         mac: '30:74:96:e2:25:01',
    //         rssi: avg(-48, -56, -56, -48, -48, -50, -50, -62, -44, -44, -74, -56, -62, -48, -48, -62),
    //     },
    //     {
    //         sensorId: 2,
    //         mac: '30:74:96:e2:25:01',
    //         rssi: avg(-64, -64, -74, -74, -56, -62, -62, -68, -68, -50, -56, -62, -62, -50, -76, -52),
    //     },
    //     {
    //         sensorId: 3,
    //         mac: '30:74:96:e2:25:01',
    //         rssi: avg(-56, -56, -62, -56, -62, -68, -56, -62, -62, -62, -62),
    //     },
    // ]
}
