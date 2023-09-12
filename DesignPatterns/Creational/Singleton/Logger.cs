namespace DesignPatterns.Creational.Singleton
{
    public class Logger
    {
        private static Logger? _instance;
        private Logger()
        {

        }

        public static Logger Instance
        {
            get { return _instance ?? (_instance = new Logger()); }
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
