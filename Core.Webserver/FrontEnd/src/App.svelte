<script>
    import FloorPlanVisualiser from './components/FloorPlanVisualiser.svelte';
    import { currentFloor } from './stores.js';

    export let name = 'WhisperWatch';

    function updateFloor(floor) {
        console.log('updating to ' + floor);
        currentFloor.set(floor);
    }
</script>

<main>
    <header>
        <img class="logo-eye" src="assets/eye.png" alt="WhisperWatch eye logo">
        <img class="logo-txt" src="assets/logo.svg" alt="WhisperWatch text">
    </header>
    <section class="sidebar">
        <nav>
            <h2>Etager</h2>
            <ul>
                <li on:click={() => updateFloor(5)}>5. sal</li>
                <li on:click={() => updateFloor(6)}>6. sal</li>
                <li on:click={() => updateFloor(7)}>7. sal</li>
            </ul>
        </nav>
    </section>
    <FloorPlanVisualiser class="content" />
</main>

<style>
    main {
        height: 100vh;
        display: grid;
        grid-template-columns: 10rem 1fr;
        grid-template-rows: 4rem 1fr;
        grid-template-areas: "header header"
                             "sidebar content";
    }

    header {
        grid-area: header;
        padding: 0 2rem;
        background-color: #222;
        display: flex;
        align-items: center;
    }

    .logo-txt {
        height: 1.5rem;
    }
    .logo-eye {
        height: 2rem;
        margin-right: 1rem;
    }

    .content {
        grid-area: content;
    }

    .sidebar {
        grid-area: sidebar;
        background-color: #eee;
    }

    nav > ul {
        list-style-type: none;
        padding: 0;
        margin: 0;
    }

    nav > ul > li {
        padding: 0.5rem 2rem;
        font-weight: 600;
        cursor: pointer;
    }

    nav > ul > li:hover {
        background-color: #e7e7e7;
    }

    nav > h2 {
        font-weight: 700;
        font-size: 1.1rem;
        padding: 1rem 0 0 1.25rem;
    }
</style>