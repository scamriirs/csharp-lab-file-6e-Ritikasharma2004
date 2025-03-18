// Create a program to show the usage of parameterized constructor, parameterless and default constructor

using System;
class DemoConstructor
{
    private string message;

    // Parameterless (default) constructor
    public DemoConstructor()
    {
        message = "This is the default constructor.";
        Console.WriteLine(message);
    }

    // Parameterized constructor
    public DemoConstructor(string customMessage)
    {
        message = customMessage;
        Console.WriteLine("Parameterized Constructor Message: " + message);
    }
}

class Program
{
    static void Main()
    {
        // Calling the default constructor
        DemoConstructor obj1 = new DemoConstructor();
        
        // Calling the parameterized constructor
        DemoConstructor obj2 = new DemoConstructor("Hello, this is a custom message!");
    }
}
