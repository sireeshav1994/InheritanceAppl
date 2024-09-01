// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Base class
public class Animal
{
  public string Name { get; set; }

  public void Eat()
  {
    Console.WriteLine($"{Name} is eating.");
  }

  public void Sleep()
  {
    Console.WriteLine($"{Name} is sleeping.");
  }
}

// Derived class
public class Dog : Animal
{
  public void Bark()
  {
    Console.WriteLine($"{Name} is barking.");
  }
}
public class Program
{
  public static void Main(string[] args)
  {
    // Create an instance of the derived class
    Dog dog = new Dog();
    dog.Name = "Buddy";

    // Call methods from the base class
    dog.Eat();  // Output: Buddy is eating.
    dog.Sleep(); // Output: Buddy is sleeping.

    // Call method from the derived class
    dog.Bark(); // Output: Buddy is barking.
  }
}
