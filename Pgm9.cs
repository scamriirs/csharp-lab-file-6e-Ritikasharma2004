// create a program to show the concept of method overloading
using System;

class Display
{
    public void Show(int number)
    {
        Console.WriteLine("Single Number: " + number);
    }

    public void Show(int number1, int number2)
    {
        Console.WriteLine("Two Numbers: " + number1 + " and " + number2);
    }
}

class Program
{
    static void Main()
    {
        Display obj = new Display();

        obj.Show(10);       

        obj.Show(10, 20);   
    }
}
