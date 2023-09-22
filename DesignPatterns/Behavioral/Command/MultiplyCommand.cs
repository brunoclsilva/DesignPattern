namespace DesignPatterns.Behavioral.Command
{
    public class MultiplyCommand : ICommand
    {
        private readonly double _valueToMultiply;
        public MultiplyCommand(double valueToMultiply)
        {
            _valueToMultiply = valueToMultiply;
        }
        public double Execute(double currentValue) => currentValue *= _valueToMultiply;
        public double Undo(double currentValue) => currentValue /= _valueToMultiply;
    }
}
