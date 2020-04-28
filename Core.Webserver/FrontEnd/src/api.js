import exampleResponse from './api-response-max.json';

export async function getData() {
    const res = await fetch('https://127.0.0.1:44396/api/buildings/1/floors/1/rooms');
    const data = await res.json();

    // Brug denne linje i stedet, hvis det gemte datasæt skal bruges
    // const data = exampleResponse;

    return data;
}
