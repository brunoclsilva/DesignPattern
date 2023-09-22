namespace DesignPatterns.Structural.Facade
{
    public class WeatherService
    {
        public double GetCurrentTemperature(Location location) => new Random().Next(32, 115);
    }
}
