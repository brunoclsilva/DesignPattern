namespace DesignPatterns.Structural.Composite
{
    public abstract class Component
    {
        public string Name { get; }

        public Component(string name)
        {
            this.Name = name;
        }

        public abstract int GetSalary();
    }
}
