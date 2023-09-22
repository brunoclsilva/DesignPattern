namespace DesignPatterns.Behavioral.ChainResponsability
{
    public class EmailLogger : ILogger
    {
        public ILogger? Next
        {
            get; set;
        }

        public void Log(string message, EnumLogLevel level)
        {
            if (level == EnumLogLevel.Error)
            {
                Console.WriteLine($"[Email Logger] {level}: {message}");
            }
            else
            {
                Next?.Log(message, level);
            }
        }
    }
}
