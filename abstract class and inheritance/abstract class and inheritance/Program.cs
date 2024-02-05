using System;

// Abstract class
abstract class Animal
{
    // Properties
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    // Getter methods
    public string GetName() { return Name; }
    public string GetColour() { return Colour; }
    public int GetAge() { return Age; }

    // Setter methods
    public void SetName(string name) { Name = name; }
    public void SetColour(string colour) { Colour = colour; }
    public void SetAge(int age) { Age = age; }

    // Abstract method
    public abstract void Eat();
}

// Dog class
class Dog : Animal
{
    // Implementation of abstract method
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}

// Cat class
class Cat : Animal
{
    // Implementation of abstract method
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}

class Program
{
    static void Main()
    {
        // Test Dog object
        Console.WriteLine("Enter a dog name: ");
        string dogName = Console.ReadLine();
        Dog myDog = new Dog();
        myDog.SetName(dogName);
        myDog.SetColour("Brown");
        myDog.SetAge(3);

        Console.WriteLine($"Dog Name: {myDog.GetName()}");
        Console.WriteLine($"Dog Colour: {myDog.GetColour()}");
        Console.WriteLine($"Dog Age: {myDog.GetAge()}");
        myDog.Eat();

        // Test Cat object
        Console.WriteLine("\nEnter a cat name: ");
        string catName = Console.ReadLine();
        Cat myCat = new Cat();
        myCat.SetName(catName);
        myCat.SetColour("White");
        myCat.SetAge(2);

        Console.WriteLine($"Cat Name: {myCat.GetName()}");
        Console.WriteLine($"Cat Colour: {myCat.GetColour()}");
        Console.WriteLine($"Cat Age: {myCat.GetAge()}");
        myCat.Eat();
    }
}
