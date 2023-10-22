namespace AdapterPattern
{
    /// <summary>
    /// Adapter Class
    /// </summary>
    public class CurrencyAdapter : ICurrencyService
    {
        private readonly CurrencyExternal _currencyService;

        public CurrencyAdapter(CurrencyExternal currencyService)
        {
            _currencyService = currencyService;
        } 

        public List<string> GetCurrencies()
        {
            var resultList = new List<string>();
            var currencyList = _currencyService.GetCurrencyList();
            currencyList.ForEach(x => resultList.Add(x.CurrencyName));
            return resultList;
        }
    }
}
