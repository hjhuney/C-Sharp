# Mathematical Operators

## Basic Operations

* Addition + 
* Subtraction - 
* Multiplication *
* Division /
* Modulus %

```
using System;

public class Maths
{
    static public void Main()
    {
        int number1 = 5;
        int number2 = 3;
        int total;
        total = number1 + number2;
        Console.WriteLine ("{0}", total);
    }
}
```

When dividing an int by another int, the result is rounded down. So 5 / 3 = 1. In order to divide two ints, either need to turn one of them into a floating point number or typecast such as below:

```
using System;

public class Maths
{
    static public void Main()
    {
        int number1 = 5;
        int number2 = 3;
        int total;
        total = number1 + (float) number2;
        Console.WriteLine ("{0}", total);
    }
}
```

Modulus (%) gives you the remainder. 

```
5 % 3 = 2
```



