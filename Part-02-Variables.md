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


## Strings and Chars

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

## Resources

C# Data Types, [link](http://zetcode.com/lang/csharp/datatypes/)
