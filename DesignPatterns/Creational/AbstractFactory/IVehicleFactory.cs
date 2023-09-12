namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IVehicleFactory
    {
        IBike GetBike(int bike);
        IScooter GetScooter(int scooter);
    }
}
