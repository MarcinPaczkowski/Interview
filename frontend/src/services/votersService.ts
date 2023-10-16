import { ITable, IVoter, ModalType } from "../models";

export const getVoters = async () => {
    const rawResponse = await fetch("https://localhost:44308/api/voters", {
        method: "GET",
        headers: {
        "Content-Type": "application/json",
        "Access-Control-Allow-Origin": "*",
        },
    });
    const response = rawResponse.json();
    return response;
};

export const createVoter = async (name: string) => {
    const rawResponse = await fetch("https://localhost:44308/api/voters", {
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

export const mapVotersToTable = (voters: IVoter[] | undefined) : ITable | null => {
    if (!voters) return null;
    
    const rows = voters.map((v) => {
        return [v.name, v.hasVoted ? "X" : "V"];
      });
    const votersTable: ITable = {
        title: "Voters",
        action: ModalType.Voter,
        headers: ["Name", "Has voted"],
        rows,
    };
    return votersTable;
}