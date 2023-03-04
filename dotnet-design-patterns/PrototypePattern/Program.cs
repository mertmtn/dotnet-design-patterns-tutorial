using PrototypePattern;

var personel1 = new Personel("Mert", "Metin");
var personel2 = (Personel)personel1.Clone();

Console.WriteLine("Person 1 Name:{0} \nPerson 2 Name:{1}", personel1.Name, personel2.Name);

Console.WriteLine("Object Hash 1:{0} Object Hash 2:{1}", personel1.ToString(), personel2.ToString());

string resultMessage = (personel1.Equals(personel2)) ? "Objects are same." : "Objects are not same";
Console.WriteLine(resultMessage);
