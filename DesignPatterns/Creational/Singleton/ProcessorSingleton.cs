namespace DesignPatterns.Creational.Singleton
{
    public class ProcessorSingleton
    {
        public ProcessorSingleton()
        {
            var logger = Logger.Instance;
            logger.LogInfo("Singleton pattern running...");
        }
    }
}
