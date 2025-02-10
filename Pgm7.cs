//write a program to find smallest element in an array
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 5, 7, 19, 3, 8 };

        int smallest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }
        Console.WriteLine("The smallest element in the array is: " + smallest);
    }
}
