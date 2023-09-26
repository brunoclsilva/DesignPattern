namespace DesignPatterns.Behavioral.Observer
{
    public class Stock : ISubject
    {
        public string Symbol { get; set; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObservers();
                }

            }
        }
        public Stock(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
        }

        private readonly List<IObserver> _observers = new();
        public void NotifyObservers() => _observers.ForEach(observer => observer.Update(Symbol, Price));
        public void Subscribe(IObserver observer) => _observers.Add(observer);
        public void Unsubscribe(IObserver observer) => _observers.Remove(observer);
    }
}
