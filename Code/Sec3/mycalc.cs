using System;

public class MyCalculator
{
    static public void Main()
    {
        // calculate circumference
        string radius;
        Console.Clear();
        Console.WriteLine("Please enter the radius: ");
        radius = Console.ReadLine();

        // convert string to float
        float rad = Convert.ToSingle(radius);
        float c = 2 * 3.14f * rad;
        Console.WriteLine("The circumference is {0}", c);
    }
}
