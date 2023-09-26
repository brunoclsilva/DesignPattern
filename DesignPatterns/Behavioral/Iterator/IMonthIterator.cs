namespace DesignPatterns.Behavioral.Iterator
{
    public interface IMonthIterator
    {
        string Current { get; }
        bool MoveNext();
        void Reset();
    }
}
