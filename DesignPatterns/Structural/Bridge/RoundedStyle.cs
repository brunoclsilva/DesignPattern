namespace DesignPatterns.Structural.Bridge
{
    public class RoundedStyle : Style
    {
        public override void Decorate() => Console.WriteLine("rounded.");
    }
}
