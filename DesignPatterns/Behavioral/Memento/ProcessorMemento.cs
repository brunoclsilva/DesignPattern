namespace DesignPatterns.Behavioral.Memento
{
    public class ProcessorMemento
    {
        public ProcessorMemento()
        {
            var originator = new Originator
            {
                State = "State 1"
            };

            Console.WriteLine($"Original State: {originator.State}");

            Console.WriteLine("Saving original State on memento...");
            var memento = originator.SaveState();

            originator.State = "State 2";
            Console.WriteLine($"Changing the original State to {originator.State}");

            Console.WriteLine("Restoring original State saved on memento...");
            originator.RestoreState(memento);

            Console.WriteLine($"Original State: {originator.State}");
        }
    }
}
