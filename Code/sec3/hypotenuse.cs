using System;

public class HypotenuseCalculator
{
    static public void Main()
    {
        // calculate circumference
        string sideA;
        string sideB;

        Console.Clear();
        Console.WriteLine("Let's calculate the hypotenuse!");
        Console.WriteLine("Enter length of side A: ");
        sideA = Console.ReadLine();
        Console.WriteLine("Enter length of side B: ");
        sideB = Console.ReadLine();

        float a = Convert.ToSingle(sideA);
        float b = Convert.ToSingle(sideB);

        // Math.Pow takes doubles, but will allow us to use float since it's smaller
        double h2 = Math.Pow(a,2) + Math.Pow(b,2);
        double h = Math.Sqrt(h2);
        
        Console.WriteLine("The length is {0}", h);

    }
}