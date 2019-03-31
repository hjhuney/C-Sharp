using System;

public class ForLoop
{
    static public void Main ()
    {
        string input = "";

        while(input != "Quit")
        {
            Console.WriteLine("Enter a value: ");
            input = Console.ReadLine();           
        }
        Console.WriteLine("Program Over. Good-bye.");
    }
}