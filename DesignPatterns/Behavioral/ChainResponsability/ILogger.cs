namespace DesignPatterns.Behavioral.ChainResponsability
{
    public interface ILogger
    {
        void Log(string message, EnumLogLevel level);
        ILogger? Next { get; set; }
    }
}
