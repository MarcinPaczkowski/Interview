import { useContext } from "react";
import InterviewContext from "../contexts/interviewContext";
import { mapCandidatesToTable } from "../services/candidatesService";
import Table from "./Table";

const Candidates = () => {
  const { candidates } = useContext(InterviewContext);

  return <Table data={mapCandidatesToTable(candidates)} />;
};

export default Candidates;
