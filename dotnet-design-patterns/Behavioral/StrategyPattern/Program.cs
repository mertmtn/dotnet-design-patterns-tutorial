using StrategyPattern;
using StrategyPattern.ConcreteStrategy;

var dbLog = new LogContext(new DatabaseLog());
dbLog.LogSomething("to db");

var fileLog = new LogContext(new FileLog());
fileLog.LogSomething("to file");