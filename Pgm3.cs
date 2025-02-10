// create a program to show the usage of parameterised , parameterless , and default constructor
using System;

class Example
{
    int id;
    string name;
    // default constructor
    public Example()
    {
        id = 0;        
        name = "Unknown";  
        Console.WriteLine("Default Constructor Called");
    }

    // Parameterized constructor
    public Example(int id, string name)
    {
        this.id = id;
        this.name = name;
        Console.WriteLine("Parameterized Constructor Called");
    }

    // Parameterless constructor 
    public Example(string name)
    {
        this.name = name;
        this.id = 0; 
        Console.WriteLine("Parameterless Constructor Called");
    }

    // Method to display the values of id and name
    public void Display()
    {
        Console.WriteLine($"ID: {id}, Name: {name}");
    }

    public static void Main()
    {
        
        Example e1 = new Example();  
        e1.Display(); 
        Example e2 = new Example(101, "John");  
        e2.Display();
        Example e3 = new Example("Alice"); 
        e3.Display(); 
    }
}
