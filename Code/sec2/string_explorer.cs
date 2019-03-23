using System;
public class StringExplorer
{
    static public void Main ()
    {
        string s = "Alpaca";
        string v = s + " Llamington";
        Console.WriteLine ("{0}", s);
        Console.WriteLine ("{0}", s.Length);
        // backslash-n "\n" will create new line
        Console.WriteLine ("{0} \n{1}", v, v.Length);
    }
}