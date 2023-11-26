namespace VisitorPattern
{
    public class CompanyABC(string founder, int foundedYear, string sector) : Company(founder, foundedYear, sector)
    {
        public override void Accept(IVisitor visit) => visit.Visit(this);

        public override string GetBalanceReportByQuarter(int quarter) => $"ABC Şirketi için Q{quarter} bilanço raporu";

        public override void GetCompanyInformationReport()
        {
            Console.WriteLine($"ABC Şirketi");
            Console.WriteLine($"Kuruluş Yılı:{FoundedYear}");
            Console.WriteLine($"Kurucusu:{Founder}");
            Console.WriteLine("Şirkete özel bilgiler.");
        }
    }
}
