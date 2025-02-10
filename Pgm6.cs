//write a program to find the integer and fraction part of a number using out keyword
using System;

class Program
{
    static void SplitNumber(double number, out int integerPart, out double fractionPart)
    {
        integerPart = (int)number;            
        fractionPart = number - integerPart;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        int integerPart;
        double fractionPart;

        SplitNumber(number, out integerPart, out fractionPart);

        Console.WriteLine("Integer part: " + integerPart);
        Console.WriteLine("Fractional part: " + fractionPart);
    }
}
