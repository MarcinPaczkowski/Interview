import { useContext } from "react";
import { SubmitHandler, useForm } from "react-hook-form";
import InterviewContext from "../contexts/interviewContext";
import { vote } from "../services/voteService";
import Select from "./Select";

interface IFormInputs {
  voterId: number;
  candidateId: number;
}

export const VoteForm = () => {
  const { register, handleSubmit } = useForm<IFormInputs>();

  const { candidates, voters, markAsChanged } = useContext(InterviewContext);

  const onSubmit: SubmitHandler<IFormInputs> = async (data) => {
    await vote(data);
    markAsChanged();
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)} className="flex flex-row">
      <Select
        label="Voter:"
        registerHandler={register("voterId")}
        items={voters}
      />
      <Select
        label="Candidate:"
        registerHandler={register("candidateId")}
        items={candidates}
      />
      <input
        type="submit"
        className="
          hover:bg-gray-300
          bg-gray-700
          text-white
          font-bold
          text-md
          py-2
          px-4
          rounded
          cursor-pointer"
      />
    </form>
  );
};
