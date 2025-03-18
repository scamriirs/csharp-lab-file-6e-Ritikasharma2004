// Write a program to simply display all the information about yourself.
using System;

class PersonalInfo
{
    private string name;
    private int age;
    private string address;
    private string profession;

    // Constructor to initialize information
    public PersonalInfo(string name, int age, string address, string profession)
    {
        this.name = name;
        this.age = age;
        this.address = address;
        this.profession = profession;
    }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Personal Information");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Profession: {profession}");
        Console.WriteLine("----------------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object with personal details
        PersonalInfo person = new PersonalInfo("Ritika Sharma", 20, "New Delhi, India", "Student");
        
        // Displaying the information
        person.DisplayInfo();
    }
}
