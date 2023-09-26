namespace DesignPatterns.Behavioral.Mediator
{
    public class Colleague2 : Colleague
    {
        public Colleague2(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message) => Console.WriteLine($"Colleague2 received {message}");
    }
}
