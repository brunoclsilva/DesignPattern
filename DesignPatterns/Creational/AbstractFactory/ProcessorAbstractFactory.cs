namespace DesignPatterns.Creational.AbstractFactory
{
    public class ProcessorAbstractFactory
    {
        public ProcessorAbstractFactory()
        {
            Console.WriteLine("Choose a brand: ");
            Console.WriteLine("1 - Honda");
            Console.WriteLine("2 - Hero");
            Int32.TryParse(Console.ReadLine(), out int brand);

            if (brand == (int)EnumBrand.Honda || brand == (int)EnumBrand.Hero)
            {
                Console.WriteLine("Choose a vehicle type: ");
                Console.WriteLine("1 - Regular");
                Console.WriteLine("2 - Sport");
                Int32.TryParse(Console.ReadLine(), out int type);

                IVehicleFactory vehicleFactory = brand == (int)EnumBrand.Honda ? new HondaFactory() : new HeroFactory();
                VehicleClient vehicleClient = new VehicleClient(vehicleFactory, type);

                Console.WriteLine($"Brand: {(EnumBrand)brand}");
                Console.WriteLine(vehicleClient.GetBikeName());
                Console.WriteLine(vehicleClient.GetScooterName());
            }
        }
    }
}
