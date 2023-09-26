namespace DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        public void Update(string symbol, decimal price);
    }
}
