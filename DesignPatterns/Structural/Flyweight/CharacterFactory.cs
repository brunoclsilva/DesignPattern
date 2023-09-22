namespace DesignPatterns.Structural.Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, ICharacter> _characters = new();

        public ICharacter GetCharacter(char symbol, int size, string font)
        {
            var key = symbol.ToString() + size.ToString() + font;

            if (!_characters.ContainsKey(key))
            {
                _characters.Add(key, new Character(symbol, size, font));
            }

            return _characters[key];
        }
    }
}
