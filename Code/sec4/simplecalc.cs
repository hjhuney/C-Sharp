using System;

public class GuessMyNumber
{
    static public void Main ()
    {
        float number1;
        float number2;
        string op;

        Console.Clear();
        Console.WriteLine("Enter Number 1");
        number1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        number2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Operator");
        op = Console.ReadLine();

        switch(op)
        {

            case "merf":
                Console.WriteLine("{0}", number1 * number2);
                break;

            // note that if we're checking for an int, we don't use quotes
            // in this case, it's impossible to input an input since we read it as a string
            case 7:
                Console.WriteLine("{0}", number1 * number2);
                break;

            case "*":
                Console.WriteLine("{0}", number1 * number2);
                break;

            case "/":
                Console.WriteLine("{0}", number1 / number2);
                break;

            case "+":
                Console.WriteLine("{0}", number1 + number2);
                break;

            case "-":
                Console.WriteLine("{0}", number1 - number2);
                break;

            default:
                Console.WriteLine("Cannot do calculation");
                break;
        }

    }
}