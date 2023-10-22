using AdapterPattern;

var currencyAdaptee = new CurrencyExternal();
ICurrencyService currencyService = new CurrencyAdapter(currencyAdaptee);

foreach (var item in currencyService.GetCurrencies())
{
    Console.WriteLine(item);
}
