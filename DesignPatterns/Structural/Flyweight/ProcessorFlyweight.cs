namespace DesignPatterns.Structural.Flyweight
{
    public class ProcessorFlyweight
    {
        public ProcessorFlyweight()
        {
            var factory = new CharacterFactory();

            var char1 = factory.GetCharacter('A', 12, "Arial");
            char1.Display();

            var char2 = factory.GetCharacter('B', 14, "Times New Roman");
            char2.Display();

            var char3 = factory.GetCharacter('A', 12, "Arial");
            char3.Display();
        }
    }
}
