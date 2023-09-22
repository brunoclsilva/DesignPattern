namespace DesignPatterns.Structural.Facade
{
    public class ConverterService
    {
        public double ConvertFToC(double f) => (f - 32) * 5 / 9;
    }
}
