using StrategyPattern;
using StrategyPattern.ConcreteStrategy;

var dbLog = new LogContext(new DatabaseLog());
dbLog.Information(new LogInformation { Message="Info message"});

var fileLog = new LogContext(new FileLog());
fileLog.Warning(new LogInformation { Message = "Warning message" });