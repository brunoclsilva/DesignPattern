namespace DesignPatterns.Structural.Facade
{
    public class GeoLookupService
    {
        public Location GetLocationByCity(string city)
        {
            return new Location(15, 20);
        }
    }
}
