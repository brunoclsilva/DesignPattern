namespace DesignPatterns.Structural.Bridge
{
    public class Rectangle : Shape
    {
        public Rectangle(Style style) : base(style)
        {
        }

        public override void ApplyStyle()
        {
            Console.Write("Make the rectangle ");
            Style.Decorate();
        }
    }
}
