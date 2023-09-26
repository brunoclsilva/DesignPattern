namespace DesignPatterns.Behavioral.Iterator
{
    public class ProcessorIterator
    {
        public ProcessorIterator()
        {
            var months = new Months();

            Console.WriteLine("Fiscal month start in January:");
            var iterator = months.CreateIterator();
            while (iterator.MoveNext())
            {
                Console.Write($"{iterator.Current} ");
            }

            Console.WriteLine();

            Console.WriteLine("Choose a month to be the fiscal month start: (Ex.1 - Jan, 2 - Feb, ..., 12 - Dec)");
            Int32.TryParse(Console.ReadLine(), out int fiscalMonth);
            months.FiscalMonthStart = fiscalMonth;

            iterator = months.CreateIterator();
            while (iterator.MoveNext())
            {
                Console.Write($"{iterator.Current} ");
            }
        }
    }
}
