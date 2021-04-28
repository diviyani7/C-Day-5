using System.IO;
using System;

public abstract class Animal
{
    private string name;
    public void SetName(string _name)
    {
        name = _name;
    }
    public string GetName()
    {
        return name;
    }
    public abstract void Eat();
}
public class Dog:Animal
{
    public override void Eat()
    {
        Console.WriteLine("The Dog is Eating");
    }
    public static void Main()
    {
        Dog dog= new Dog();
		Console.WriteLine( "Enter the name of the dog: ");
        dog.SetName(Console.ReadLine());
        dog.GetName();
        dog.Eat();
    }
}