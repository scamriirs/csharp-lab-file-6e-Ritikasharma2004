// write a program to print detial of a student if the student is sport person then give extra 5 marks
using System;

class Person
{
    string name;
    string address;
    int contactno;

    public void getdata(string n, string a, int c)
    {
        name = n;
        address = a;
        contactno = c;
    }

    public void displaydata()
    {
        Console.WriteLine("Name is " + name);
        Console.WriteLine("Address is " + address);
        Console.WriteLine("Contact number is " + contactno);
    }
}

interface Result
{
    void calculateresult(string s, int m);
}

class student : Person, Result
{
    int id;
    int marks;

    public void getdetail(int i, int m)
    {
        id = i;
        marks = m;
    }

    public void displaydetail()
    {
        Console.WriteLine("Id is " + id);
        Console.WriteLine("Marks are " + marks);
    }

    public void calculateresult(string s, int m)
    {
        marks = m;
        if (s == "Y")
        {
            m += 5;
            Console.WriteLine("Total marks are " + m);
        }
        else
        {
            Console.WriteLine("Total marks are " + m);
        }
    }
}

class Test
{
    public static void Main()
    {
        student s = new student();
        s.getdata("Ritika", "Delhi", 12345);
        s.getdetail(1, 10);
        s.calculateresult("Y", 10);
        s.displaydata();
        s.displaydetail();
    }
}
