namespace AdapterPattern
{
    /// <summary>
    /// Adapter Class
    /// </summary>
    public class CurrencyAdapter : ICurrencyService
    {
        CurrencyExternal _currencyService;
        public CurrencyAdapter()
        {
            _currencyService = new CurrencyExternal();
        }

        public double ConvertMoney(double unit, string currency)
        {
            return _currencyService.Convert(unit, currency);
        }

        public List<string> GetCurrencies()
        {
            return _currencyService.GetCurrencyList();
        }

        public double GetCurrencyForToday(string currency)
        {
            return _currencyService.GetCurrencyValue(currency);
        }
    }
}
