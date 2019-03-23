using System;

public class ExchangeConversion
{
    static public void Main()
    {
        // calculate circumference
        string exchangeRate;
        string amount;
        float usd;

        Console.Clear();        
        Console.WriteLine("Enter conversion ratio: ");
        exchangeRate = Console.ReadLine();
        Console.WriteLine("Enter amount to convert: ");
        amount = Console.ReadLine();

        float a = Convert.ToSingle(exchangeRate);
        float b = Convert.ToSingle(amount);

        // Math.Pow takes doubles, but will allow us to use float since it's smaller
        usd = b * a;
        
        Console.WriteLine("You will receive {0} US dollars", usd);

    }
}