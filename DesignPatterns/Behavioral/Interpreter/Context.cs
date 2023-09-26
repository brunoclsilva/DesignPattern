namespace DesignPatterns.Behavioral.Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, int> _variables;

        public Context()
        {
            _variables = new Dictionary<string, int>();
        }

        public void SetVariable(string name, int value)
        {
            _variables[name] = value;
        }

        public int GetVariable(string name)
        {
            if (_variables.TryGetValue(name, out var value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException($"Variable '{name}' not found.");
            }
        }
    }
}
