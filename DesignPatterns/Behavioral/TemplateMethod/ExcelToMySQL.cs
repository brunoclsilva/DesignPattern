namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class ExcelToMySQL : ETL
    {
        protected override string[] Extract(string filename)
        {
            return new string[] { "1,2,3", "4,5,6" };
        }

        protected override string[] Transform(string[] data)
        {
            Console.WriteLine("Excel data transformed to CSV format");
            return data;
        }

        protected override void Load(string[] data)
        {
            Console.WriteLine("Data stored in MySQL");
        }
    }
}
