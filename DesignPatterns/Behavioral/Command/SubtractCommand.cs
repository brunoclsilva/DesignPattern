namespace DesignPatterns.Behavioral.Command
{
    public class SubtractCommand : ICommand
    {
        private readonly double _valueToSubtract;
        public SubtractCommand(double valueToSubtract)
        {
            _valueToSubtract = valueToSubtract;
        }
        public double Execute(double currentValue) => currentValue -= _valueToSubtract;
        public double Undo(double currentValue) => currentValue += _valueToSubtract;
    }
}
