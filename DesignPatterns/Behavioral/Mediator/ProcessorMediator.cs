namespace DesignPatterns.Behavioral.Mediator
{
    public class ProcessorMediator
    {
        public ProcessorMediator()
        {
            var mediator = new ConcreteMediator();
            var c1 = new Colleague1(mediator);
            var c2 = new Colleague2(mediator);

            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            Console.WriteLine("To exit the conversation, just say Bye");
            string message;
            do
            {
                Console.WriteLine("Type a message from Colleague1 to Colleague2: ");
                message = Console.ReadLine();
                c1.Send(message);

                if(message?.ToLower() != "bye")
                {
                    Console.WriteLine("Type a message from Colleague2 to Colleague1: ");
                    message = Console.ReadLine();
                    c2.Send(message);
                }
            }
            while (message?.ToLower() != "bye");
        }
    }
}
