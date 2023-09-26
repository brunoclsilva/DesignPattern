namespace DesignPatterns.Behavioral.Interpreter
{
    public abstract class Expression
    {
        public abstract int Interpret(Context context);
    }
}
