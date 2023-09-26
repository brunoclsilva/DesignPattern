namespace DesignPatterns.Behavioral.Interpreter
{
    public class DivideExpression : Expression
    {
        private readonly Expression _left;
        private readonly Expression _right;
        public DivideExpression(Expression leftExpression, Expression rightExpression)
        {
            _left = leftExpression;
            _right = rightExpression;
        }
        public override int Interpret(Context context)
        {
            return _left.Interpret(context) / _right.Interpret(context);
        }
    }
}
