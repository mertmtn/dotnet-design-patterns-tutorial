namespace PrototypePattern
{
    public class Personel : PersonelPrototype
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }

        public Personel(string name, string surname)
        {
            Name = name;
            Surname = surname;

            var r = new Random();
            Number = r.Next();
        }

        public override string ToString()
        {
            return GetHashCode().ToString();
        } 

        public override PersonelPrototype Clone()
        {
            return MemberwiseClone() as PersonelPrototype;
        }
    }

    public abstract class PersonelPrototype
    {
        public abstract PersonelPrototype Clone();
    }
}