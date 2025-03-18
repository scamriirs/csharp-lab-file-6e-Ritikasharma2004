// write a program to automate the admission letter for university student , name course , fees will vary collage name,college address, college branding , college disclaimer will be fix
using System;

// Abstract class defining the common properties
abstract class Student
{
    public string Name { get; set; }
    public string Course { get; set; }
    public double Fees { get; set; }
    
    public abstract void GenerateAdmissionLetter();
}

// Concrete class implementing the abstract class
class UniversityStudent : Student
{
    private const string CollegeName = "Manav Rachna University";
    private const string CollegeAddress = "Sector 43, Faridabad, Haryana, India";
    private const string CollegeBranding = "Excellence in Education Since 1995";
    private const string CollegeDisclaimer = "This admission letter is subject to university policies and regulations.";

    public UniversityStudent(string name, string course, double fees)
    {
        Name = name;
        Course = course;
        Fees = fees;
    }

    public override void GenerateAdmissionLetter()
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Admission Letter from {CollegeName}");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"To: {Name}");
        Console.WriteLine($"Course: {Course}");
        Console.WriteLine($"Total Fees: ₹{Fees:N2}");
        Console.WriteLine();
        Console.WriteLine("College Details:");
        Console.WriteLine(CollegeAddress);
        Console.WriteLine();
        Console.WriteLine(CollegeBranding);
        Console.WriteLine(CollegeDisclaimer);
        Console.WriteLine("------------------------------------------------");
    }
}

class Program
{
    static void Main()
    {
        
        UniversityStudent student = new UniversityStudent("Ritika Sharma", "Bachelor of Computer Applications (BCA)", 250000);
        
        // Generating the admission letter
        student.GenerateAdmissionLetter();
    }
}
