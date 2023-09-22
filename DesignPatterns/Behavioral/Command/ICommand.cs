namespace DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        double Execute(double value);
        double Undo(double value);
    }
}
