namespace currency_converter;

public class CurrencyConverter
{
    public decimal Dollar { get; }
    public decimal Euro { get; }
    public decimal SEK { get; }

    public CurrencyConverter(decimal dollar, decimal euro, decimal sek)
    {
        Dollar = dollar;
        Euro = euro;
        SEK = sek;
    }

    public decimal ConvertDollarToSEK(decimal amount)
    {
        return amount / Dollar * SEK;
    }

    public decimal ConvertEuroToDollar(decimal amount)
    {
        return amount / Euro * Dollar;
    }

    public decimal ConvertSEKToEuro(decimal amount)
    {
        return amount / SEK * Euro;
    }

    public decimal ConvertEuroToSEK(decimal amount)
    {
        return amount / Euro * SEK;
    }

    // Add other conversion methods as needed
}
