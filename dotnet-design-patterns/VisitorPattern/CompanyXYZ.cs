namespace VisitorPattern
{
    public class CompanyXYZ(string founder, int foundedYear, string sector) : Company(founder, foundedYear, sector)
    {
        public override void Accept(IVisitor visit) => visit.Visit(this);

        public override string GetBalanceReportByQuarter(int quarter) => $"XYZ Şirketi için Q{quarter} bilanço raporu";

        public override void GetCompanyInformationReport()
        {
            Console.WriteLine($"XYZ Şirketi");
            Console.WriteLine("Şirkete özel bilgiler.");
        }
    }
}
