namespace DesignPatterns.Behavioral.Iterator
{
    public class Months : IAggregate
    {
        private readonly string[] _months = {
            "Jan","Feb","Mar",
            "Apr","May","Jun",
            "Jul","Aug","Sep",
            "Oct","Nov","Dec",
        };

        public int FiscalMonthStart { get; set; } = 1;

        public IMonthIterator CreateIterator()
        {
            return new MonthIterator(_months, FiscalMonthStart);
        }
    }
}
