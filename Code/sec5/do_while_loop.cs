using System;

public class ForLoop
{
    static public void Main ()
    {
        int i;
        Console.Clear();
        Console.WriteLine("Enter 1 for options\n" +
                    "       2 to quit \n" + 
                    "       3 to start game.");
        
        do
        {
            Console.WriteLine("Option?");
            i = Convert.ToInt32(Console.ReadLine());
        }
        while(i < 1 || i > 3);

    }
}