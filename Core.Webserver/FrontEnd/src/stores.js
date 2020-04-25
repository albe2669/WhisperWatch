import { readable, writable } from 'svelte/store';

export const sensors = readable([
    {
        location: {
            x: 0,
            y: 20,
        },
        id: 1,
    },
    {
        location: {
            x: 10 + 10.88,
            y: 20,
        },
        id: 2,
    },
    {
        location: {
            x: 10,
            y: 0,
        },
        id: 3,
    },
    {
        location: {
            x: 10,
            y: 20 + 12.8,
        },
        id: 4,
    },
]);

export const currentFloor = writable(5);
