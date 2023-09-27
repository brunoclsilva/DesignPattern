namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class ProcessorTemplateMethod
    {
        public ProcessorTemplateMethod()
        {
            var csvSqlServerImport = new CSVToSQLServer();
            csvSqlServerImport.ImportData("data.csv");

            var excelMySqlImport = new ExcelToMySQL();
            excelMySqlImport.ImportData("data.xlsx");
        }
    }
}
