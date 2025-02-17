//write a program of jagged array
using System;

class JaggedArrayExample
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[3] { 1, 2, 3 };  // Row 0 has 3 elements
        jaggedArray[1] = new int[2] { 4, 5 };     // Row 1 has 2 elements
        jaggedArray[2] = new int[4] { 6, 7, 8, 9 }; // Row 2 has 4 elements

        Console.WriteLine("Jagged Array Elements:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        jaggedArray[1][1] = 10; // Changing the second element of row 1 to 10

        Console.WriteLine("\nAfter modification:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
