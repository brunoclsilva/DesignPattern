namespace DesignPatterns.Behavioral.Memento
{
    public class Memento
    {
        public string? State { get; set; }

        public Memento(string? state)
        {
            State = state;
        }
    }
}
