namespace DesignPatterns.Structural.Bridge
{
    public class SketchedStyle : Style
    {
        public override void Decorate() => Console.WriteLine("sketched.");
    }
}
