namespace AdapterPattern
{
    /// <summary>
    /// Adaptee - Third party library or external API
    /// </summary>
    public class CurrencyExternal
    {
        public double Convert(double unit, string currency)
        {
            return unit / GetCurrencyValue(currency);
        }

        public double GetCurrencyValue(string currency)
        {
            return 20.12;
        }

        public List<string> GetCurrencyList()
        {
            return new List<string>() { "Dollar", "Euro", "Sterlin", "Lari" };
        }
    }
}
