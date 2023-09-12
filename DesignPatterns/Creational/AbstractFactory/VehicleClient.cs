namespace DesignPatterns.Creational.AbstractFactory
{
    public class VehicleClient
    {
        private readonly IBike bike;
        private readonly IScooter scooter;

        public VehicleClient(IVehicleFactory factory, int type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
