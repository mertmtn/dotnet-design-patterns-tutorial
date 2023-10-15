using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SingletonPattern
{
    public class DbConnection
    {
        public int Number { get; set; }

        //Thread Safe kontrolü yapacağımız Lock Objesi
        private static readonly object checkThreadSafe = new();

        //Static field
        private static DbConnection _dbConnect;

        //Private Constructor 
        private DbConnection()
        {
            var r = new Random();
            Number = r.Next();
        }

        //Static Property
        public static DbConnection DbConnect
        {
            get
            {
                lock (checkThreadSafe)
                {
                    if (_dbConnect == null)
                        _dbConnect = new DbConnection();
                }
                return _dbConnect;
            }
        }
    }
}