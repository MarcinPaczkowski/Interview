import { createContext } from "react";
import { ICandidate, IVoter } from "../models";

const InterviewContext = createContext({
    isDataChanged: false,
    candidates: [] as ICandidate[],
    voters: [] as IVoter[],
    markAsChanged: () => {}
});

export default InterviewContext
