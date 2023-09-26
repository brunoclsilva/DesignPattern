namespace DesignPatterns.Behavioral.Observer
{
    public class Logger : IObserver
    {
        private readonly ISubject _subject;
        private readonly string _filename;

        public Logger(ISubject subject, string filename)
        {
            _subject = subject;
            _subject.Subscribe(this);

            _filename = filename;
        }

        public void Update(string symbol, decimal price)
        {
            using var streamWriter = File.AppendText(_filename);
            streamWriter.WriteLine($"{symbol}:{price}");
        }
    }
}
