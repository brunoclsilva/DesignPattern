namespace DesignPatterns.Creational.Builder
{
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            report.ReportContent = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            report.ReportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            report.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            report.ReportType = "PDF";
        }
    }
}
