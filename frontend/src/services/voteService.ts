export const vote = async ({voterId, candidateId} : {voterId: number, candidateId: number}) => {
    const rawResponse = await fetch("https://localhost:44308/api/vote", {
        method: "POST",
        headers: {
        "Content-Type": "application/json",
        "Access-Control-Allow-Origin": "*",
        },
        body: JSON.stringify({voterId, candidateId})
    });
    const response = rawResponse.json();
    return response;
};