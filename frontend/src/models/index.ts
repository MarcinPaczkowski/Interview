export enum ModalType {
  Candidate,
  Voter
}

export interface ITable {
  title: string;
  action: ModalType;
  headers: string[];
  rows: string[][];
}

export interface ICandidate {
    id: number;
    name: string;
    castedVotes: number;
}

export interface IVoter {
    id: number;
    name: string;
    hasVoted: boolean;
}