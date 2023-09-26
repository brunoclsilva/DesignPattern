namespace DesignPatterns.Behavioral.Interpreter
{
    public class ProcessorInterpreter
    {
        public ProcessorInterpreter()
        {
            Console.WriteLine("Let's solve the following expression: 10 + 20*(x + y)");
            Console.WriteLine("Choose x: ");
            Int32.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Choose y: ");
            Int32.TryParse(Console.ReadLine(), out int y);

            var context = new Context();
            context.SetVariable("x", x);
            context.SetVariable("y", y);

            // -> 10 + 20*(x + y)
            var expression = new AddExpression(
                new NumberExpression(10),
                new MultiplyExpression(
                    new NumberExpression(20),
                    new AddExpression(
                        new NumberExpression(context.GetVariable("x")),
                        new NumberExpression(context.GetVariable("y"))
                    )
                )
            );

            var result = expression.Interpret(context);

            Console.WriteLine("Result: " + result);
        }
    }
}
