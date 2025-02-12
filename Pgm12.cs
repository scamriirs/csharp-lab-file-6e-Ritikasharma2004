// create a program to find the longest sequence of position number in 1d array {1,2,3,-4,2,3,4,5,-6,-7,1,2,3}
using System;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, -4, 2, 3, 4, 5, -6, -7, 1, 2, 3};

        int longestStart = 0; 
        int longestLength = 1;
        int currentStart = 0; 
        int currentLength = 1; 

        for (int i = 1; i < array.Length; i++)
        {
           
            if (array[i] == array[i - 1] + 1)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestStart = currentStart;
                }

                currentStart = i;
                currentLength = 1;
            }
        }
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }

        Console.WriteLine("Longest consecutive sequence length: " + longestLength);
        Console.Write("Longest consecutive sequence: ");
        for (int i = longestStart; i < longestStart + longestLength; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
