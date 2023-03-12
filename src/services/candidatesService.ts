import { ICandidate, ITable, ModalType } from "../models";

export const getCandidates = async () => {
    const rawResponse = await fetch("https://localhost:44308/api/candidates", {
        method: "GET",
        headers: {
        "Content-Type": "application/json",
        "Access-Control-Allow-Origin": "*",
        },
    });
    const response = rawResponse.json();
    return response;
};

export const createCandidate = async (name: string) => {
    const rawResponse = await fetch("https://localhost:44308/api/candidates", {
        method: "POST",
        headers: {
        "Content-Type": "application/json",
        "Access-Control-Allow-Origin": "*",
        },
        body: JSON.stringify({name})
    });
    const response = rawResponse.json();
    return response;
};

export const mapCandidatesToTable = (candidates: ICandidate[] | undefined) : ITable | null => {
    if (!candidates) return null;
    
    const rows = candidates.map((c) => {
        return [c.name, c.castedVotes.toString()];
      });
    const candidatesTable: ITable = {
        title: "Candidates",
        action: ModalType.Candidate,
        headers: ["Name", "Votes"],
        rows,
    };
    return candidatesTable;
}