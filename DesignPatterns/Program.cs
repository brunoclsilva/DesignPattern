using DesignPatterns.Behavioral.ChainResponsability;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

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
            Console.WriteLine("10 - Facade");
            Console.WriteLine("11 - Flyweight");
            Console.WriteLine("12 - Proxy");
            Console.WriteLine("\nBEHAVIORAL");
            Console.WriteLine("13 - Chain of Responsability");
            Console.WriteLine("14 - Command");
            Console.WriteLine("15 - Interpreter");
            Console.WriteLine("16 - Iterator");
            Console.WriteLine("17 - Mediator");
            Console.WriteLine("18 - Memento");
            Console.WriteLine("19 - Observer");
            Console.WriteLine("20 - State");
            Console.WriteLine("21 - Strategy");
            Console.WriteLine("22 - Template Method");
            Console.WriteLine("23 - Visitor");

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
                case (int)EnumPattern.Facade:
                    _ = new ProcessorFacade();
                    break;
                case (int)EnumPattern.Flyweight:
                    _ = new ProcessorFlyweight();
                    break;
                case (int)EnumPattern.Proxy:
                    _ = new ProcessorProxy().Execute();
                    break;
                case (int)EnumPattern.ChainResponsability:
                    _ = new ProcessorChainResposability();
                    break;
                case (int)EnumPattern.Command:
                    _ = new ProcessorCommand();
                    break;
                case (int)EnumPattern.Interpreter:
                    _ = new ProcessorInterpreter();
                    break;
                case (int)EnumPattern.Iterator:
                    _ = new ProcessorIterator();
                    break;
                case (int)EnumPattern.Mediator:
                    _ = new ProcessorMediator();
                    break;
                case (int)EnumPattern.Memento:
                    _ = new ProcessorMemento();
                    break;
                case (int)EnumPattern.Observer:
                    _ = new ProcessorObserver();
                    break;
                case (int)EnumPattern.State:
                    _ = new ProcessorState();
                    break;
                case (int)EnumPattern.Strategy:
                    _ = new ProcessorStrategy();
                    break;
                case (int)EnumPattern.TemplateMethod:
                    _ = new ProcessorTemplateMethod();
                    break;
                case (int)EnumPattern.Visitor:
                    _ = new ProcessorVisitor();
                    break;
                default:
                    throw new ArgumentException("You must choose a pattern from the list above!");
            }

            Console.WriteLine();
            Console.WriteLine($"End of {(EnumPattern)pattern} execution!");
        }
    }
}