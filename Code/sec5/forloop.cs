using System;

public class ForLoop
{
    static public void Main ()
    {
        // for (initial state, condition, increment value )
        for (int i = 1; i <= 100; i = i + 2)
        {
            Console.WriteLine("{0}", i);
        }
    }
}
