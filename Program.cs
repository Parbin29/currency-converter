using System;
using currency_converter;

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

        // Create an Account
        var account = new Account
        {
            Id = 1,
            Balance = money
        };
        Console.WriteLine($"Account ID: {account.Id}, Balance: {account.Balance.Amount} {account.Balance.Currency}");

        // Create Money in Euro
        var euroMoney = new Money(100m, Currency.Euro);
        Console.WriteLine($"Initial Money: {euroMoney.Amount} {euroMoney.Currency}");

        // Convert Money to SEK
        euroMoney.ChangeCurrency(Currency.SEK, converter);
        Console.WriteLine($"After Conversion: {euroMoney.Amount} {euroMoney.Currency}");

        // Create an Account
        var account2 = new Account
        {
            Id = 2,
            Balance = euroMoney
        };
        Console.WriteLine($"Account ID: {account2.Id}, Balance: {account2.Balance.Amount} {account2.Balance.Currency}");

        // Create Money in Euro
        var moneyDollar = new Money(120m, Currency.Euro);
        Console.WriteLine($"Initial Money: {moneyDollar.Amount} {moneyDollar.Currency}");

        // Convert Money to Dollar
        moneyDollar.ChangeCurrency(Currency.Dollar, converter);
        Console.WriteLine($"After Conversion: {moneyDollar.Amount} {moneyDollar.Currency}");

        // Create an Account
        var account3 = new Account
        {
            Id = 3,
            Balance = moneyDollar
        };
        Console.WriteLine($"Account ID: {account3.Id}, Balance: {account3.Balance.Amount} {account3.Balance.Currency}");
    }
}

