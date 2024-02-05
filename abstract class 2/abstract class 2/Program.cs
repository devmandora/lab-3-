using System;
using System.Collections.Generic;

interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    int Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();
}

class Dog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

class Cat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

class Program
{
    static void Main()
    {
        // For Dog
        Console.Write("Enter Dog's name: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        dog.Name = dogName;

        Console.Write("Enter Dog's height: ");
        dog.Height = int.Parse(Console.ReadLine());

        Console.Write("Enter Dog's colour: ");
        dog.Colour = Console.ReadLine();

        Console.Write("Enter Dog's age: ");
        dog.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dog Details:");
        Console.WriteLine($"Name: {dog.Name}");
        Console.WriteLine($"Height: {dog.Height}");
        Console.WriteLine($"Colour: {dog.Colour}");
        Console.WriteLine($"Age: {dog.Age}");

        dog.Eat();
        Console.WriteLine($"Dog says: {dog.Cry()}");

        // For Cat
        Console.Write("\nEnter Cat's name: ");
        string catName = Console.ReadLine();

        Cat cat = new Cat();
        cat.Name = catName;

        Console.Write("Enter Cat's height: ");
        cat.Height = int.Parse(Console.ReadLine());

        Console.Write("Enter Cat's colour: ");
        cat.Colour = Console.ReadLine();

        Console.Write("Enter Cat's age: ");
        cat.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Cat Details:");
        Console.WriteLine($"Name: {cat.Name}");
        Console.WriteLine($"Height: {cat.Height}");
        Console.WriteLine($"Colour: {cat.Colour}");
        Console.WriteLine($"Age: {cat.Age}");

        cat.Eat();
        Console.WriteLine($"Cat says: {cat.Cry()}");

        // List of animals
        List<IAnimal> animals = new List<IAnimal> { dog, cat };

        Console.WriteLine("\nNames of all animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}
