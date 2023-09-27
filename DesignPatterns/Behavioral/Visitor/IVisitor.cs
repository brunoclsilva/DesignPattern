namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(BackOfficeEmployee e);
        void Visit(SalesEmployee e);
    }
}
