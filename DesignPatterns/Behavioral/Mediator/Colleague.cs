namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public abstract void Receive(string message);
    }
}
