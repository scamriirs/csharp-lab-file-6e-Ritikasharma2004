// create a program to show the usage of static constructor
using System;

class Example
{
    static Example()
    {
        Console.WriteLine("static constructor");
    }

    Example()
    {
        Console.WriteLine("non-static constructor");
    }

    public static void Main()
    {
        Example e1 = new Example();  
        Example e2 = new Example();  
    }
}
