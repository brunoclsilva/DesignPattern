namespace DesignPatterns.Creational.Prototype
{
    public class ProcessorPrototype
    {
        public ProcessorPrototype()
        {
            Console.WriteLine("Creating Loki object...");
            var loki = new Warrior("Loki", 100, 20);
            Console.WriteLine(loki);

            var thor = loki.Clone();
            thor.Name = "Thor";
            thor.Health = 120;

            Console.WriteLine("\nCloning Loki to Thor and changing Name/Health properties...\n");

            Console.WriteLine(loki);
            Console.WriteLine(thor);
        }
    }
}
