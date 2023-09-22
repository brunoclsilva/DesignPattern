namespace DesignPatterns.Behavioral.ChainResponsability
{
    public class ConsoleLogger : ILogger
    {
        public ILogger? Next { get; set; }

        public void Log(string message, EnumLogLevel level)
        {
            if (level == EnumLogLevel.Debug || level == EnumLogLevel.Info)
            {
                Console.WriteLine($"[Console Logger] {level}: {message}");
            }
            else
            {
                Next?.Log(message, level);
            }
        }
    }
}
