import { useContext } from "react";
import { SubmitHandler, useForm } from "react-hook-form";
import InterviewContext from "../contexts/interviewContext";
import { createCandidate } from "../services/candidatesService";
import Input from "./Input";

interface IFormInputs {
  name: string;
}

export const CandidateForm = ({ submit }: { submit: any }) => {
  const { register, handleSubmit } = useForm<IFormInputs>();

  const { markAsChanged } = useContext(InterviewContext);

  const onSubmit: SubmitHandler<IFormInputs> = async (data) => {
    createCandidate(data.name);
    markAsChanged();
    submit();
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)} className="flex flex-row">
      <Input label="Name" registerHandler={register("name")} />
      <button
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
      >
        Add new candidate
      </button>
    </form>
  );
};

export default CandidateForm;
