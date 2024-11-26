using System;
using csharp_object;

class Program
{
    static void Main()
    {
        // Create a CurrencyConverter with initial rates
        var converter = new CurrencyConverter(0.095m, 0.085m, 1.0m);

        // Create Money in SEK
        var money = new Money(100m, Currency.SEK);
        Console.WriteLine($"Initial Money: {money.Amount} {money.Currency}");

        // Convert Money to Euro
        money.ChangeCurrency(Currency.Euro, converter);
        Console.WriteLine($"After Conversion: {money.Amount} {money.Currency}");

        // Create Money in Euro
        var moneyEuro = new Money(100m, Currency.Euro);
        Console.WriteLine($"Initial Money: {moneyEuro.Amount} {moneyEuro.Currency}");

        // Convert Money to SEK
        moneyEuro.ChangeCurrency(Currency.SEK, converter);
        Console.WriteLine($"After Conversion: {moneyEuro.Amount} {moneyEuro.Currency}");

        // Create an Account
        var account = new Account
        {
            Id = 1,
            Balance = money
        };
        Console.WriteLine($"Account ID: {account.Id}, Balance: {account.Balance.Amount} {account.Balance.Currency}");
    }
}

