// create a program to find the sum of element of  2d matrix
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                sum += matrix[i, j]; 
            }
        }
        Console.WriteLine("Sum of all elements in the matrix: " + sum);
    }
}
