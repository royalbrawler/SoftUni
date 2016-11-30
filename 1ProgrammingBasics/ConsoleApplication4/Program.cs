
using System;
//Problem 14: Currency Converter
class CurrencyConverter
{
    static void Main(string[] args)
    {
        decimal amount = decimal.Parse(Console.ReadLine());
        string currencyOne = Console.ReadLine();
        string currencyTwo = Console.ReadLine();
        decimal BGN = 1;
        decimal USD = 1.79549m;
        decimal EUR = 1.95583m;
        decimal GBP = 2.53405m;
        switch (currencyOne)
        {
            case "BGN":
                amount = amount * BGN;
                break;
            case "USD":
                amount = amount * USD;
                break;
            case "EUR":
                amount = amount * EUR;
                break;
            case "GBP":
                amount = amount * GBP;
                break;
        }
        switch (currencyTwo)
        {
            case "BGN":
                amount = amount / BGN;
                break;
            case "USD":
                amount = amount / USD;
                break;
            case "EUR":
                amount = amount / EUR;
                break;
            case "GBP":
                amount = amount / GBP;
                break;
        }
        Console.WriteLine(Math.Round(amount, 2));
    }
}