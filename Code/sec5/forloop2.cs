using System;

public class ForLoop
{
    static public void Main ()
    {
        int total = 0;
        Console.Clear();
        Console.WriteLine("Please enter values: ");


        // for (initial state, condition, increment value )
        for (int i = 1; i <= 5; i+=1)
        {
            Console.WriteLine("Enter value {0}", i);
            total = total + Convert.ToInt32(Console.ReadLine());
        }

        float avg = total / (float)10.0f;
        Console.WriteLine("The average is {0}.", avg);
    }
}