namespace DesignPatterns.Structural.Bridge
{
    public abstract class Shape
    {
        protected Style Style;

        public Shape(Style style)
        {
            Style = style;
        }

        public abstract void ApplyStyle();
    }
}
