using System;

public class MyCalculator
{
    static public void Main()
    {
        // calculate circumference
        string number1;
        string number2;
        int num1;
        int num2;

        Console.Clear();
        Console.WriteLine("Please enter value 1: ");
        number1 = Console.ReadLine();
        Console.WriteLine("Please enter value 2: ");
        number2 = Console.ReadLine();

        // convert string to float
        num1 = Convert.ToInt32(number1);
        num2 = Convert.ToInt32(number2);

        Console.WriteLine("The addition of {0} and {1} is {2}", num1, num2, num1+num2);
    }
}