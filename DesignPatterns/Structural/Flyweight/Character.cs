namespace DesignPatterns.Structural.Flyweight
{
    public class Character : ICharacter
    {
        private readonly char _symbol;
        private readonly int _size;
        private readonly string _font;

        public Character(char symbol, int size, string font)
        {
            _symbol = symbol;
            _size = size;
            _font = font;
        }

        public void Display()
        {
            Console.WriteLine($"Symbol: {_symbol}, Size: {_size}, Font: {_font}");
        }
    }
}
