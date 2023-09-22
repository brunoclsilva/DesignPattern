namespace DesignPatterns.Structural.Composite
{
    public class Leaf : Component
    {
        public int Salary { get; }
        
        public Leaf(string Name, int Salary) : base(Name)
        {
            this.Salary = Salary;
        }
        
        public override int GetSalary()
        {
            Console.WriteLine($"\t Name: {Name} and Salary: {Salary}");
            return Salary;
        }
    }
}
