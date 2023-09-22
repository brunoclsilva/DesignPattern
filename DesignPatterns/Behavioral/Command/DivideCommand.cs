namespace DesignPatterns.Behavioral.Command
{
    public class DivideCommand : ICommand
    {
        private readonly double _valueToDivide;
        public DivideCommand(double valueToDivide)
        {
            _valueToDivide = valueToDivide;
        }
        public double Execute(double currentValue) => currentValue /= _valueToDivide;
        public double Undo(double currentValue) => currentValue *= _valueToDivide;
    }
}
