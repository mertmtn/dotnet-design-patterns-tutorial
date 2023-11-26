
namespace VisitorPattern.Visitors
{
    public class BarGraphVisitor : IVisitor
    {
        public void Visit(CompanyABC companyABC)
        {
            Console.WriteLine($"Bar Graph balance report for {nameof(CompanyABC)}");
            Console.WriteLine("Bar Graph drawn");
        }

        public void Visit(CompanyXYZ companyXYZ)
        {
            Console.WriteLine($"Bar Graph balance report for {nameof(CompanyXYZ)}");
            Console.WriteLine("Bar Graph drawn");
        }
    }
}
