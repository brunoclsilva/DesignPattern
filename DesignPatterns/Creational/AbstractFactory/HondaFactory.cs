namespace DesignPatterns.Creational.AbstractFactory
{
    public class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(int bike)
        {
            switch (bike)
            {
                case (int)EnumTypeVehicle.Regular:
                    return new RegularBike();
                case (int)EnumTypeVehicle.Sports:
                    return new SportsBike();
                default:
                    throw new ArgumentException("Vehicle cannot be created!");
            }
        }

        public IScooter GetScooter(int scooter)
        {
            switch (scooter)
            {
                case (int)EnumTypeVehicle.Regular:
                    return new RegularScooter();
                case (int)EnumTypeVehicle.Sports:
                    return new Scooty();
                default:
                    throw new ArgumentException("Vehicle cannot be created!");
            }
        }
    }
}
