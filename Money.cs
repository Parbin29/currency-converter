namespace currency_converter;

public class Money
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }

    public Money(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public void ChangeCurrency(Currency newCurrency, CurrencyConverter converter)
    {
        if (Currency == newCurrency)
        {
            return;
        }

        switch (Currency)
        {
            case Currency.Dollar when newCurrency == Currency.SEK:
                Amount = converter.ConvertDollarToSEK(Amount);
                break;
            case Currency.SEK when newCurrency == Currency.Euro:
                Amount = converter.ConvertSEKToEuro(Amount);
                break;
            case Currency.Euro when newCurrency == Currency.Dollar:
                Amount = converter.ConvertEuroToDollar(Amount);
                break;
            case Currency.Euro when newCurrency == Currency.SEK:
                Amount = converter.ConvertEuroToSEK(Amount);
                break;
            default:
                throw new NotImplementedException("Conversion not implemented.");
        }

        Currency = newCurrency;
    }
}
