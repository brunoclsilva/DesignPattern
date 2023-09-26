namespace DesignPatterns.Behavioral.Interpreter
{
    public class NumberExpression : Expression
    {
        private readonly int number;
        public NumberExpression(int number)
        {
            this.number = number;
        }
        public override int Interpret(Context context)
        {
            return number;
        }
    }
}
