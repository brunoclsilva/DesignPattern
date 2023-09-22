namespace DesignPatterns.Behavioral.ChainResponsability
{
    public class ProcessorChainResposability
    {
        public ProcessorChainResposability()
        {
            var consoleLogger = new ConsoleLogger();
            var fileLogger = new FileLogger();
            var emailLogger = new EmailLogger();

            consoleLogger.Next = fileLogger;
            fileLogger.Next = emailLogger;

            consoleLogger.Log("This is a debug message", EnumLogLevel.Debug);
            consoleLogger.Log("This is an info message", EnumLogLevel.Info);
            consoleLogger.Log("This is a warning message", EnumLogLevel.Warning);
            consoleLogger.Log("This is an error message", EnumLogLevel.Error);
        }
    }
}
