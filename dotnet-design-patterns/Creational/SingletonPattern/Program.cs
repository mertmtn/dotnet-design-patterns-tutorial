using SingletonPattern;

var dbConnectionOne = DbConnection.DbConnect;
var dbConnectionTwo = DbConnection.DbConnect;

Console.WriteLine("Number 1:{0} \nNumber 2:{1}", dbConnectionOne.Number, dbConnectionTwo.Number);
 
string resultMessage = (dbConnectionOne == dbConnectionTwo) ? "Objects are same." : "Objects are not same";
Console.WriteLine(resultMessage);