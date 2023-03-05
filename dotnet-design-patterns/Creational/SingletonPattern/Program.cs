using SingletonPattern;

var personel1 = Personel.PersonelInstance;
var personel2 = Personel.PersonelInstance;

Console.WriteLine("Number 1:{0} Number 2:{1}", personel1.Number, personel2.Number);
 
string resultMessage = (personel1 == personel2) ? "Objects are same." : "Objects are not same";
Console.WriteLine(resultMessage);