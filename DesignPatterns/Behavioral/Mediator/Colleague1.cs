namespace DesignPatterns.Behavioral.Mediator
{
    public class Colleague1 : Colleague
    {
        public Colleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message) => Console.WriteLine($"Colleague1 received {message}");
    }
}
