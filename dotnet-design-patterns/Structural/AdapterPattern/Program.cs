using AdapterPattern;

ICurrencyService currencyService = new CurrencyAdapter();

foreach (var item in currencyService.GetCurrencies())
{
    Console.WriteLine(item);
}
