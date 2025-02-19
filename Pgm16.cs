// write a program to implement the concept of interface (interface bank roi()) (class - HDFC,SBI,ICICI)
using System;

interface Bank
{
    void roi();
}

class ICICI : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 7%");
    }
}

class HDFC : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest is 6.5%");
    }
}

class SBI : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest is 6%");
    }
}

class Test
{
    public static void Main()  // Make this method static
    {
        Bank b;

        b = new ICICI();
        b.roi();

        b = new HDFC();
        b.roi();

        b = new SBI();
        b.roi();
    }
}
