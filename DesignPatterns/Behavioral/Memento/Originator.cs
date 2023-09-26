namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        public string? State { get; set; }

        public void RestoreState(Memento memento)
        {
            State = memento.State;
        }

        public Memento SaveState()
        {
            return new Memento(State);
        }
    }
}
