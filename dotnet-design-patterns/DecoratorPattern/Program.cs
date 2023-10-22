using DecoratorPattern.RealLifeScenario.Logging;
 
var fileLog = new FileLog();
fileLog.Information(new LogInformation() { Message = "Logged to file", LogSource = "File" });

Console.WriteLine("----------"); 

try
{
    int dividend = 5;
    int divider = 0;
    int result = dividend / divider;
    Console.WriteLine(result);
}
catch (Exception ex)
{
    var logDecorator = new MailLogDecorator(new GraylogLog());
    logDecorator.Error(ex, new LogInformation() { Message = "An error occurred - Graylog Id:" + Guid.NewGuid(),LogSource="GrayLog" }); 
}