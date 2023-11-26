namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(CompanyABC companyABC);
        void Visit(CompanyXYZ companyXYZ);
    }
}
 