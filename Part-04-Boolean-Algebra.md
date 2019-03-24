# Boolean Algebra

## Relational Operators

```
Less than <
Greater than >
Less than or equal to <=
Greater than or equal to >=
Equal to ==
Not equal to !=
```

If Statement

```
// pseudo-code

if (boolean statement)
{
  do this;
}
else
{
  do this;
}
```

## Switch Statement

In C#, the switch statement is similar to if-elif statements. In the example below, our program asks the user for two numbers.
It then asks for an operator. The switch statement checks for various operators and then performs an action if the condition is met. 
Otherwise, it will reach the "default" (similar to else) and run that condition. 

```
using System;

public class GuessMyNumber
{
    static public void Main ()
    {
        float number1;
        float number2;
        string op;

        Console.Clear();
        Console.WriteLine("Enter Number 1");
        number1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        number2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Operator");
        op = Console.ReadLine();

        switch(op)
        {

            case "merf":
                Console.WriteLine("{0}", number1 * number2);
                break;

            case "*":
                Console.WriteLine("{0}", number1 * number2);
                break;

            case "/":
                Console.WriteLine("{0}", number1 / number2);
                break;

            case "+":
                Console.WriteLine("{0}", number1 + number2);
                break;

            case "-":
                Console.WriteLine("{0}", number1 - number2);
                break;

            default:
                Console.WriteLine("Cannot do calculation");
                break;
        }

    }
}
```

## Logical Operators

* && - and
* || - or

When using && or ||, use parenthesis such as in the example below:

```
if (answer == (a && b))
{
  Console.WriteLine("True");
}
```

