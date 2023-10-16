import { useEffect, useState } from "react";
import Candidates from "./components/Candidates";
import { Vote } from "./components/Vote";
import Voters from "./components/Voters";
import InterviewContext from "./contexts/interviewContext";
import { ICandidate, IVoter } from "./models";
import { getCandidates } from "./services/candidatesService";
import { getVoters } from "./services/votersService";

const App = () => {
  const markAsChanged = () => {
    setInterviewData((prev) => ({
      ...prev,
      isDataChanged: true,
    }));
  };
  const [interviewData, setInterviewData] = useState({
    isDataChanged: false,
    candidates: [] as ICandidate[],
    voters: [] as IVoter[],
    markAsChanged,
  });

  useEffect(() => {
    Promise.all([getCandidates(), getVoters()]).then((values) => {
      const candidates = values[0].payload;
      const voters = values[1].payload;
      setInterviewData({
        isDataChanged: false,
        candidates,
        voters,
        markAsChanged,
      });
    });
  }, [interviewData.isDataChanged]);

  return (
    <InterviewContext.Provider value={interviewData}>
      <div className="App w-full p-4 content-center justify-center">
        <div className="container w-full">
          <div className="p-4">
            <h1 className="text-2xl font-bold">Voting app</h1>
          </div>
          <div className="flex flex-row justify-between">
            <Voters />
            <Candidates />
          </div>
          <hr className="w-full h-1 bg-gray-100 rounded border-0 my-4 dark:bg-gray-700"></hr>
          <div className="flex flex-row justify-between px-4">
            <Vote />
          </div>
        </div>
      </div>
    </InterviewContext.Provider>
  );
};

export default App;
