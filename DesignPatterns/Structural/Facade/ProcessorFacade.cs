namespace DesignPatterns.Structural.Facade
{
    public class ProcessorFacade
    {
        public ProcessorFacade()
        {
            var city = "New York";
            var weatherServiceFacade = new WeatherServiceFacade();
            var temperatureInC = weatherServiceFacade.GetCurrentTemperatureByCity(city);

            Console.WriteLine($"The current temperature in {city} is {temperatureInC:F1}°C");
        }
    }
}
