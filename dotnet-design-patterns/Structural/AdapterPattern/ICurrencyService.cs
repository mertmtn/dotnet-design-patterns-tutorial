namespace AdapterPattern
{
    /// <summary>
    /// Target - web request ->Client
    /// </summary>
    public interface ICurrencyService
    { 
        public List<string> GetCurrencies();
    }
}
