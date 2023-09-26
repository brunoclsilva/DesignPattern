namespace DesignPatterns.Behavioral.Observer
{
    public class Display : IObserver
    {
        private readonly ISubject _subject;
        public Display(ISubject subject)
        {
            _subject = subject;
            _subject.Subscribe(this);
        }
        public void Update(string symbol, decimal price)
        {
            Console.WriteLine($"New price for {symbol}: {price}");
        }
    }
}
