// write a program to automate the offer letter using abstract class person name , date of joining , designation , salary will vary and company name , company address , company binding , company disclaimer will be fix
using System;

// Abstract class defining the common properties
abstract class Person
{
    public string Name { get; set; }
    public DateTime DateOfJoining { get; set; }
    public string Designation { get; set; }
    public double Salary { get; set; }
    
    public abstract void GenerateOfferLetter();
}

// Concrete class implementing the abstract class
class Employee : Person
{
    private const string CompanyName = "Tech Innovators India Pvt Ltd";
    private const string CompanyAddress = "456, Electronic City, Bengaluru, India";
    private const string CompanyBinding = "This offer is binding as per company policies and Indian labor laws.";
    private const string CompanyDisclaimer = "This offer is confidential and should not be shared with anyone.";

    public Employee(string name, DateTime dateOfJoining, string designation, double salary)
    {
        Name = name;
        DateOfJoining = dateOfJoining;
        Designation = designation;
        Salary = salary;
    }

    public override void GenerateOfferLetter()
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Offer Letter from {CompanyName}");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"To: {Name}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Date of Joining: {DateOfJoining:dd MMM yyyy}");
        Console.WriteLine($"Salary: ₹{Salary:N2} per annum");
        Console.WriteLine();
        Console.WriteLine("Company Details:");
        Console.WriteLine(CompanyAddress);
        Console.WriteLine();
        Console.WriteLine(CompanyBinding);
        Console.WriteLine(CompanyDisclaimer);
        Console.WriteLine("------------------------------------------------");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Ritika Sharma", new DateTime(2025, 4, 1), "Software Engineer", 1200000);
        
        // Generating the offer letter
        emp.GenerateOfferLetter();
    }
}

