namespace VisitorPattern
{
    public abstract class Company(string founder, int foundedYear, string sector)
    {
        public string Founder => founder;
        public int FoundedYear => foundedYear;
        public string Sector => sector;
        public abstract void GetCompanyInformationReport();
        public abstract string GetBalanceReportByQuarter(int quarter);
        public abstract void Accept(IVisitor visit);
    }
}
