namespace DesignPatterns.Structural.Bridge
{
    public class Triangle : Shape
    {
        public Triangle(Style style) : base(style)
        {
        }

        public override void ApplyStyle()
        {
            Console.Write("Make the triangle ");
            Style.Decorate();
        }
    }
}
