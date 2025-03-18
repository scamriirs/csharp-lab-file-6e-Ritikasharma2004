// Question: Implement multilevel inheritance in C# where:
// - The base class 'Animal' has a method void Eat().
// - The derived class 'Dog' inherits from 'Animal' and has methods void Breed() and void Bark().
// - The derived class 'BabyDog' inherits from 'Dog' and has a method void Weep().

using System;
// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

// Derived class from Animal
class Dog : Animal
{
    public void Breed()
    {
        Console.WriteLine("Dog belongs to a specific breed.");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking...");
    }
}

// Derived class from Dog
class BabyDog : Dog
{
    public void Weep()
    {
        Console.WriteLine("Baby dog is weeping...");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of BabyDog
        BabyDog puppy = new BabyDog();
        
        // Calling methods from all levels of inheritance
        puppy.Eat();   // Method from Animal class
        puppy.Breed(); // Method from Dog class
        puppy.Bark();  // Method from Dog class
        puppy.Weep();  // Method from BabyDog class
    }
}
