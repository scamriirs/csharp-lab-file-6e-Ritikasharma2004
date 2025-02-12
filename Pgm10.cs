// create a program to add the element of two 2d matrix
using System;

class MatrixAddition
{
    static void Main()
    {
        int[,] matrix1 = {{1, 2, 3},{4, 5, 6},{7, 8, 9}};
        
        int[,] matrix2 = {{9, 8, 7},{6, 5, 4},{3, 2, 1}};

        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Result of matrix addition:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(result[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }
    }
}
