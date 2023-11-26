// Visitor Design Pattern, dokunulmazlığı olan sınıflara yeni işlevler/fonksiyonlar/özellikler eklenmesi
// gerektiğinde kullanılan bir stratejidir.
//Yani sınıfın bir üyesi olmadan, misafir gibi gelen ve iş yapıp sonra giden
//farklı nesneler kastedilmektedir.
//Bir sınıfın herhangi bir fonksiyonunun işlevini daha da genişletmek için Decorator,
//sınıfın yeni davranış/işlev/fonksiyon kazanması için Visitor kullanılır!
using VisitorPattern;
using VisitorPattern.Visitors;

var companiesToMailReport = new List<Company>();
CompanyABC companyABC = new("AB C", 1985, "Insurance");
CompanyXYZ companyXYZ = new("XY Z", 2000, "Banking");

companiesToMailReport.Add(companyABC);
companiesToMailReport.Add(companyXYZ);


IVisitor graphVisitor = new BarGraphVisitor();
companyABC.GetCompanyInformationReport();
companyABC.Accept(graphVisitor);

Console.WriteLine("-------------");

IVisitor tableVisitor = new TableVisitor();
companyXYZ.GetCompanyInformationReport();
companyXYZ.Accept(tableVisitor);

Console.WriteLine("-------------");

IVisitor mailReportVisitor = new MailReportVisitor();
companiesToMailReport.ForEach(x => x.Accept(mailReportVisitor));
