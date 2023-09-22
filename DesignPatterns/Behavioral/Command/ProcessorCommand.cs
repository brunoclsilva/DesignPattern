namespace DesignPatterns.Behavioral.Command
{
    public class ProcessorCommand
    {
        public ProcessorCommand()
        {
            var calculator = new Calculator();

            int option = -1;
            do
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Multiply");
                Console.WriteLine("4 - Divide");
                Console.WriteLine("5 - Undo");
                Console.WriteLine("0 - Exit (see current value)");
                option = Int32.Parse(Console.ReadLine());


                switch (option)
                {
                    case (int)EnumOperation.Add:
                    case (int)EnumOperation.Subtract:
                    case (int)EnumOperation.Multiply:
                    case (int)EnumOperation.Divide:
                        Console.WriteLine("Type a number: "); // Move this line here to wait for user input
                        int number = Int32.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case (int)EnumOperation.Add:
                                calculator.ExecuteCommand(new AddCommand(number));
                                break;
                            case (int)EnumOperation.Subtract:
                                calculator.ExecuteCommand(new SubtractCommand(number));
                                break;
                            case (int)EnumOperation.Multiply:
                                calculator.ExecuteCommand(new MultiplyCommand(number));
                                break;
                            case (int)EnumOperation.Divide:
                                calculator.ExecuteCommand(new DivideCommand(number));
                                break;
                        }
                        break;
                    case (int)EnumOperation.Undo:
                        calculator.Undo();
                        break;
                }
            }
            while (option != 0);

            Console.WriteLine($"Result: {calculator.CurrentValue}");
        }
    }
}
