namespace DesignPatterns.Structural.Bridge
{
    public class ProcessorBridge
    {
        public ProcessorBridge()
        {
            Console.WriteLine("Choose the object: ");
            Console.WriteLine("1 - Triangle");
            Console.WriteLine("2 - Rectangle");
            Int32.TryParse(Console.ReadLine(), out int objectType);

            Console.WriteLine("Choose the shape of the object: ");
            Console.WriteLine("1 - Rounded");
            Console.WriteLine("2 - Sketched");
            Int32.TryParse(Console.ReadLine(), out int objectShape);

            switch (objectType)
            {
                case (int)EnumTypeObject.Triangle:
                    Triangle triangle;
                    if (objectShape == (int)EnumShape.Rounded)
                    {
                        triangle = new Triangle(new RoundedStyle());
                        triangle.ApplyStyle();
                    }
                    else if (objectShape == (int)EnumShape.Sketched)
                    {
                        triangle = new Triangle(new SketchedStyle());
                        triangle.ApplyStyle();
                    }
                    break;
                case (int)EnumTypeObject.Rectangle:
                    Rectangle rectangle;
                    if (objectShape == (int)EnumShape.Rounded)
                    {
                        rectangle = new Rectangle(new RoundedStyle());
                        rectangle.ApplyStyle();
                    }
                    else if (objectShape == (int)EnumShape.Sketched)
                    {
                        rectangle = new Rectangle(new SketchedStyle());
                        rectangle.ApplyStyle();
                    }
                    break;
                default:
                    throw new ArgumentException("Incorrect value entered!");
            }
        }
    }
}
