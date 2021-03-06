# Variables and Basic CS

## Bits and Bytes

Bit. Smallest size box in memory. Can hold a 0 or a 1. Two bits can store 4 values. 

Byte. 8 bits. Can store 256 (or 2^8) sequences. 

Example of calculation in binary. 

```
253 in binary is 1-1-1-1-1-1-0-1

2^7 = 128 * 1
2^6 = 64 * 1
2^5 = 32 * 1
2^4 = 16 * 1
2^3 = 8 * 1
2^2 = 4 * 1
2^1 = 2 * 0 (remember we have a 0 in this spot in above sequence)
2^0 = 1 * 1

128 + 64 + 32 + 16 + 8 + 4 + 0 + 1 = 253
```

## Integers

int. A signed 32 bit integer. Same as int32 in Pandas. Can hold an integer up to 4 bytes in memory. 

```
Min: - 2,147,483,648
Max: + 2,147,483,647
```

Example of using an int:

```
using System;
public class Variables
{
    static public void Main ()
    {
        int number = 5;
        Console.WriteLine ("My value is {0}", number);
    }
}
```

short. 2 bytes. 

```
Min: -32,768
Max: 32,767
```

long. 8 bytes

```
Min: -9,223,372,036,854,775,808
Max: +9,223,372,036,854,775,807
```

uint. 4 bytes, but no negative numbers.

```
Min: 0
Max: 4,294,967,295
```

ulong. 8 bytes, but no negative numbers.

```
Min: 0
Max: 18,446,744,073,709,551,615
```

## Variable Naming Rules

* Can't start with a number
* Can't include $ or symbols
* Can't use reserved words (such as "int")
* Can't put a space in name

## Floats and Doubles

float. Floating point number. 4 bytes. Precision of 7 digits. 

```
Min: -1.5 X 10^(-45)
Max: +3.4 X 10^(38)
```

In order to define a float, you need to add "f" to the end of your number. Otherwise, the C# compiler will generate an error message since you did not use a double. 

```
using System;
public class Variables
{
    static public void Main ()
    {
        float myFloat = 12.765f;
        Console.WriteLine ("My float is: {0}", myFloat);
    }
}
```

double. Double precision floating point number. 8 bytes. Precision of 15-16 digits. 

```
Min: -1.5 X 10^(-324)
Max: +1.8 X 10^(308)
```

decimal. 16 bytes. 28-29 decimal places. 

```
Min: -1.0 X 10^(-28)
Max: + 7.9 X 10^(28)
```


## Chars

char. 2 bytes. Define it using single quotes. 

```
using System;
public class Variables
{
    static public void Main ()
    {
        char myCharacter = 'A';
        Console.WriteLine ("My char is: {0}", myCharacter);
    }
}
```

## ASCII Table

The ASCII table contains all characters and their mappings. 

* [ASCII Table](https://www.cs.cmu.edu/~pattis/15-1XX/common/handouts/ascii.html)
* [Extended ASCII Table](https://www.ascii-code.com/)

If we define an int as 'A', for example, we'll get its ASCII table value. For instance:

```
using System;
public class Variables
{
    static public void Main ()
    {
        int number = 'A';
        char myCharacter = 'A';
        Console.WriteLine ("My valuess are {0} and {1}", number, myCharacter);
    }
}
```

This returns:

```
My valuess are 65 and A
```

This is because 'A' is assigned the value of 65 in the ASCII table. We can also use the ASCII value to define a character by using typecasting such as in the example below:

```
using System;
public class Variables
{
    static public void Main ()
    {
        int number = 'A';
        char myCharacter = (char) 65;
        Console.WriteLine ("My valuess are {0} and {1}", number, myCharacter);
    }
}
```

## Strings

Strings are defined with double-quote marks. We can find the length of a string with .Length. Example below:

```
using System;
public class StringExplorer
{
    static public void Main ()
    {
        string s = "Alpaca";
        Console.WriteLine ("{0}", s);
        Console.WriteLine ("{0}", s.Length);
    }
}
```

Creating a prompt with strings using Console.ReadLine():

```
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
```


## Resources

C# Data Types, [link](http://zetcode.com/lang/csharp/datatypes/)
