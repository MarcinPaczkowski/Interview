const Input = ({
  label,
  registerHandler,
}: {
  label: string;
  registerHandler: any;
}) => {
  return (
    <div className="flex flex-row items-center mr-4">
      <label className="mr-4 text-xl">{label}</label>
      <input
        {...registerHandler}
        className="block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline"
      />
    </div>
  );
};

export default Input;
