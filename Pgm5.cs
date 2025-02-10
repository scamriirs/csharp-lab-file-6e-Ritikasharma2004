//write a program to find the square of a number using pass by reference
using System;

class Program
{
    static void CalculateSquare(ref int num)
    {
        num = num * num; 
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        CalculateSquare(ref number);

        Console.WriteLine("The square of the number is: " + number);
    }
}
