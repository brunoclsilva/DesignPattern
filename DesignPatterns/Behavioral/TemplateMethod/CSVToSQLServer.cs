namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class CSVToSQLServer : ETL
    {
        protected override string[] Extract(string filename)
        {
            //return File.ReadAllLines(filename);
            return new string[] { "1,2,3", "4,5,6" };
        }

        protected override void Load(string[] data)
        {
            Console.WriteLine("Store Data in SQL Server");
        }
    }
}
