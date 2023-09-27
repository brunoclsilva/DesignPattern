namespace DesignPatterns.Behavioral.Visitor
{
    public class SalesEmployee : Employee, IVisitableElement
    {
        public decimal Commission { get; set; }
        public SalesEmployee(string name, decimal salary, decimal commission) : base(name, salary)
        {
            Commission = commission;
        }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
