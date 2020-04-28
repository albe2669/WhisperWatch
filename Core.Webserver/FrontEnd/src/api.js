import exampleResponse from './api-response-max.json';

export async function getData() {
    const res = await fetch('/api/buildings/1/floors/1/rooms');
    const data = await res.json();

    // Brug denne linje i stedet, hvis det gemte datasæt skal bruges
    // const data = exampleResponse;

    return data;
}
