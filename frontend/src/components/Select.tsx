const Select = ({
  label,
  registerHandler,
  items,
}: {
  label: string;
  registerHandler: any;
  items: any[];
}) => {
  return (
    <div className="flex flex-row items-center mr-4">
      <label className="mr-4 text-xl">{label}</label>
      <select
        {...registerHandler}
        className="block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline"
      >
        {items.map((item: any, i: any) => (
          <option key={i} value={item.id}>
            {item.name}
          </option>
        ))}
      </select>
    </div>
  );
};

export default Select;
