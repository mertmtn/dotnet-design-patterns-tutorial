
using VisitorPattern.Extensions;

namespace VisitorPattern.Visitors
{
    public class MailReportVisitor : IVisitor
    {
        public void Visit(CompanyABC companyABC)
        {
            var mailContent = companyABC.GetBalanceReportByQuarter(DateTime.Now.GetQuarter());
            Console.WriteLine($"Mail sended for {nameof(CompanyABC)} with content {mailContent}");
        }

        public void Visit(CompanyXYZ companyXYZ)
        {
            var mailContent = companyXYZ.GetBalanceReportByQuarter(DateTime.Now.GetQuarter());
            Console.WriteLine($"Mail sended for {nameof(CompanyXYZ)} with content {mailContent}");
        }
    }
}
