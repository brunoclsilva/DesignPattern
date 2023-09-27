namespace DesignPatterns.Behavioral.Visitor
{
    public class BackOfficeEmployee : Employee, IVisitableElement
    {
        public decimal Bonus { get; set; }
        public BackOfficeEmployee(string name, decimal salary, decimal bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
