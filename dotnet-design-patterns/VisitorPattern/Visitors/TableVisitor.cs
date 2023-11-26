

namespace VisitorPattern.Visitors
{
    public class TableVisitor : IVisitor
    {
        public void Visit(CompanyABC companyABC)
        {
            Console.WriteLine($"Table balance report for {nameof(CompanyABC)}");
            Console.WriteLine("Table drawn");
        }

        public void Visit(CompanyXYZ companyXYZ)
        {
            Console.WriteLine($"Table balance report for {nameof(CompanyXYZ)}");
            Console.WriteLine("Table drawn");
        }
    }
}