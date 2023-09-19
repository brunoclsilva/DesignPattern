namespace DesignPatterns.Creational.Builder
{
    public abstract class ReportBuilder
    {
        protected Report report;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            report = new Report();
        }

        public Report GetReport()
        {
            return report;
        }
    }
}
