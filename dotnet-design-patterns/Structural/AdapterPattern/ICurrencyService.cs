namespace AdapterPattern
{
    /// <summary>
    /// Target
    /// </summary>
    public interface ICurrencyService
    {
        public double GetCurrencyForToday(string currency);
        public double ConvertMoney(double unit, string currency);
        public List<string> GetCurrencies();
    }
}
