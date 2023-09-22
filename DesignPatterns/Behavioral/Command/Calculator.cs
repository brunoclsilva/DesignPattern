namespace DesignPatterns.Behavioral.Command
{
    public class Calculator
    {
        public double CurrentValue
        {
            get; private set;
        }

        public Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            CurrentValue = command.Execute(CurrentValue);
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            if(_commandHistory.Count > 0)
            {
                var command = _commandHistory.Pop();
                CurrentValue = command.Undo(CurrentValue);
            }
        }
    }
}
