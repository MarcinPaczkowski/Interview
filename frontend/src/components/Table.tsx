import { useState } from "react";
import { ITable, ModalType } from "../models";
import CandidateModal from "./CandidateModal";
import VoterModal from "./VoterModal";

const Table = ({ data }: { data: ITable | null | undefined }) => {
  const [showModal, setShowModal] = useState(false);
  if (!data) return null;

  return (
    <div className="overflow-x-auto relative w-full px-4">
      <div className="flex flex-row justify-between text-gray-500 py-3 px-6 items-center border-collapse border border-b-0 border-slate-300">
        <div className="text-center text-lg font-bold ">{data.title}</div>
        {data.action === ModalType.Candidate ? (
          <CandidateModal />
        ) : (
          <VoterModal />
        )}
      </div>
      <table className="w-full text-sm text-left text-gray-500 dark:text-gray-400 border-collapse border border-slate-400">
        <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
          <tr>
            {data.headers?.map((header, i) => (
              <th
                key={i}
                scope="col"
                className="py-3 px-6 border border-slate-300"
              >
                {header}
              </th>
            ))}
          </tr>
        </thead>
        <tbody>
          {data.rows?.map((row, i) => {
            return (
              <tr
                key={i}
                className="bg-white border-b dark:bg-gray-800 dark:border-gray-700"
              >
                {row.map((cell, j) => (
                  <td
                    key={`${i}${j}`}
                    className="py-4 px-6 font-medium text-gray-900 whitespace-nowrap dark:text-white border border-slate-300"
                  >
                    {cell}
                  </td>
                ))}
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
  );
};

export default Table;
