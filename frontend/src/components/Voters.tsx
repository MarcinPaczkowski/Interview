import { useContext } from "react";
import InterviewContext from "../contexts/interviewContext";
import { mapVotersToTable } from "../services/votersService";
import Table from "./Table";

const Voters = () => {
  const { voters } = useContext(InterviewContext);
  return <Table data={mapVotersToTable(voters)} />;
};

export default Voters;
