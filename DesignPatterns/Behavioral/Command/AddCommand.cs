namespace DesignPatterns.Behavioral.Command
{
    public class AddCommand : ICommand
    {
        private readonly double _valueToAdd;
        public AddCommand(double valueToAdd)
        {
            _valueToAdd = valueToAdd;
        }

        public double Execute(double currentValue) => currentValue += _valueToAdd;
        public double Undo(double currentValue) => currentValue -= _valueToAdd;
    }
}
