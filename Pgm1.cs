//write a program to show usage of this keyword
using System;

class Test
{
    int num;

    Test(int num)
    {
        this.num = num;  
    }

    public static void Main()
    {
        Test t = new Test(4);  
        Console.WriteLine("value is " + t.num);  
    }
}
