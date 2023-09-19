namespace DesignPatterns.Creational.Builder
{
    public class ProcessorBuilder
    {
        public ProcessorBuilder()
        {
            Console.WriteLine("Choose a Report Type: ");
            Console.WriteLine("1 - Excel");
            Console.WriteLine("2 - PDF");
            Int32.TryParse(Console.ReadLine(), out int reportType);

            ReportDirector reportDirector = new ReportDirector();
            Report report;
            switch (reportType)
            {
                case (int)EnumReportType.Excel:
                    ExcelReport excelReport = new ExcelReport();
                    report = reportDirector.MakeReport(excelReport);
                    break;
                case (int)EnumReportType.Pdf:
                    PDFReport pdfReport = new PDFReport();
                    report = reportDirector.MakeReport(pdfReport);
                    break;
                default:
                    throw new ArgumentException("Incorrect value!");
            }

            report.DisplayReport();
        }
    }
}
