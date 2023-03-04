using SingletonPattern;

try
{
    var personel1 = Personel.PersonelInstance;
    var personel2 = Personel.PersonelInstance;

    Console.WriteLine("Sayı 1:{0} Sayı 2:{1}", personel1.Number, personel2.Number);

    if (personel1 == personel2)
        Console.WriteLine("Nesneler aynıdır.");

    else
        Console.WriteLine("Nesneler farklıdır.");
}
catch (Exception e)
{
    Console.WriteLine(e.GetType());
}
finally
{
    Console.ReadLine();
}