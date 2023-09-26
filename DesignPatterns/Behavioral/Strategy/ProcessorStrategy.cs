namespace DesignPatterns.Behavioral.Strategy
{
    public class ProcessorStrategy
    {
        public ProcessorStrategy()
        {
            SortedList studentRecords = new SortedList();
            Console.WriteLine("Type some names (to finish, type Done)...");

            string name;
            do
            {
                name = Console.ReadLine();
                if (name.ToLower() != "done")
                {
                    studentRecords.Add(name);
                }
            } 
            while (name?.ToLower() != "done");

            Console.WriteLine("Choose the sorting algorithm: ");
            Console.WriteLine("1 - QuickSort");
            Console.WriteLine("2 - ShellSort");
            Console.WriteLine("3 - MergeSort");
            Int32.TryParse(Console.ReadLine(), out int algorithm);

            switch (algorithm)
            {
                case (int)EnumAlgorithmType.Quick:
                    studentRecords.SetSortStrategy(new QuickSort());
                    break;
                case (int)EnumAlgorithmType.Shell:
                    studentRecords.SetSortStrategy(new ShellSort());
                    break;
                case (int)EnumAlgorithmType.Merge:
                    studentRecords.SetSortStrategy(new MergeSort());
                    break;
                default:
                    throw new ArgumentException("You must choose an algorithm from the list above!");
            }

            studentRecords.Sort();
        }
    }
}
