using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;

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
            Console.WriteLine("\nSTRUCTURALS");
            Console.WriteLine("6 - Adapter");
            Console.WriteLine("7 - Bridge");
            Console.WriteLine("8 - Composite");
            Console.WriteLine("9 - Decorator");

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
                    _ = new ProcessorBuilder();
                    break;
                case (int)EnumPattern.Prototype:
                    _ = new ProcessorPrototype();
                    break;
                case (int)EnumPattern.Adapter:
                    _ = new ProcessorAdapter();
                    break;
                case (int)EnumPattern.Bridge:
                    _ = new ProcessorBridge();
                    break;
                case (int)EnumPattern.Composite:
                    _ = new ProcessorComposite();
                    break;
                case (int)EnumPattern.Decorator:
                    _ = new ProcessorDecorator();
                    break;
                default:
                    throw new ArgumentException("You must choose a pattern from the list above!");
            }

            Console.WriteLine();
            Console.WriteLine($"End of {(EnumPattern)pattern} execution!");
        }
    }
}