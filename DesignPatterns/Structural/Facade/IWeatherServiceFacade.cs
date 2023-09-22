namespace DesignPatterns.Structural.Facade
{
    public interface IWeatherServiceFacade
    {
        double GetCurrentTemperatureByCity(string city);
    }
}
