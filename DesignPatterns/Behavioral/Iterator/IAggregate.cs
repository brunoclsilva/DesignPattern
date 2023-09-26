namespace DesignPatterns.Behavioral.Iterator
{
    public interface IAggregate
    {
        IMonthIterator CreateIterator();
    }
}
