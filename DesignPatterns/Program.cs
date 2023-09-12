using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Design Pattern to run: ");
            Console.WriteLine("CREATIONALS");
            Console.WriteLine("1 - Singleton");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Abstract Factory");
            Console.WriteLine("4 - Builder");
            Console.WriteLine("5 - Prototype");

            Int32.TryParse(Console.ReadLine(), out int pattern);
            switch (pattern)
            {
                case (int)EnumPattern.Singleton:
                    _ = new ProcessorSingleton();
                    break;
                case (int)EnumPattern.FactoryMethod:
                    _ = new ProcessorFactoryMethod();
                    break;
                case (int)EnumPattern.AbstractFactory:
                    _ = new ProcessorAbstractFactory();
                    break;
                case (int)EnumPattern.Builder:
                    //_ = new ProcessorBuilder();
                    break;
                case (int)EnumPattern.Prototype:
                    //_ = new ProcessorPrototype();
                    break;
                default:
                    throw new ArgumentException("You must choose a pattern from the list above!");
            }

            Console.WriteLine($"End of {(EnumPattern)pattern} execution!");
        }
    }
}