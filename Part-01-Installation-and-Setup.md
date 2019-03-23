# C-Sharp Installation, Setup, and "Hello World" Program

Download Mono C# compiler [here](https://www.mono-project.com/docs/about-mono/languages/csharp/).

Set Path Environment variable to the Mono bin directory. 

First program:

```
// namespace
using System;

// class
public class HelloWorld
{
    // Main() method
    static public void Main ()
    {
        // statement
        // semi-colon is end of line
        Console.WriteLine ("Hello World!");
    }
}
```

Save file as helloworld.cs.

## Compile

To compile your program, go to the terminal and enter:

```
mcs helloworld.cs
```

This will create a helloworld.exe program. 

## Execute

To execute this .exe program, enter in the terminal:

```
mono helloworld.cs
```

And you should get output with:

```
Hello World!
```



