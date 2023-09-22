namespace DesignPatterns.Behavioral.ChainResponsability
{
    public class FileLogger : ILogger
    {
        public ILogger? Next
        {
            get; set;
        }

        public void Log(string message, EnumLogLevel level)
        {
            if (level == EnumLogLevel.Warning)
            {
                Console.WriteLine($"[File Logger] {level}: {message}");
            }
            else
            {
                Next?.Log(message, level);
            }
        }
    }
}
