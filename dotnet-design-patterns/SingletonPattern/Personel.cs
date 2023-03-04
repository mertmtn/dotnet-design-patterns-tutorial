namespace SingletonPattern
{
    public class Personel
    {
        public int Number { get; set; }

        //Thread Safe kontrolü yapacağımız Lock Objesi
        private static readonly object checkThreadSafe = new object();

        //Static field
        private static Personel _personelInstance;

        //Private Constructor 
        private Personel()
        {
            var r = new Random();
            Number = r.Next();
        }

        //Static Property
        public static Personel PersonelInstance
        {
            get
            {
                lock (checkThreadSafe)
                {
                    if (_personelInstance == null)
                    {
                        _personelInstance = new Personel();
                    }
                }
                return _personelInstance;
            }
        }

    }
}