namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : Mediator
    {
        public Colleague1 Colleague1;
        public Colleague2 Colleague2;

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Receive($"{message} from {nameof(Colleague1)}");
            }
            else if (colleague == Colleague2)
            {
                Colleague1.Receive($"{message} from {nameof(Colleague2)}");
            }
        }
    }
}
