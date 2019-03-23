using System;
public class StringExplorer
{
    static public void Main ()
    {
        string name;
        Console.WriteLine("Hello, what is your name?: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello {0}, are you a llama?", name);


    }
}