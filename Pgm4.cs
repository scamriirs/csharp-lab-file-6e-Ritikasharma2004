//write a program to find the square of a number using pass by value
using System;

class Program
{
    static void FindSquare(int num)
    {
        int square = num * num;
        Console.WriteLine($"The square of {num} is {square}");
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        FindSquare(number);
    }
}
