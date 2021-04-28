using System.IO;
using System;

public class Program
{
    public static void Main()
    {
        int i;
        int number=3;
        Person [] person = new Person[number];
        for(i=0;i<number;i++)
        {
            person[i]= new Person(Console.ReadLine());
        }
        for(i=0;i<number;i++)
        {
           Console.WriteLine(person[i].ToString());
        }
    }
public class Person
{
	public string Name{get; set;}
    public Person(string _name)
    {
        Name = _name;
    }
    public override string ToString()
    {
        return Name;
    }
    ~Person()
    {
        Name = string.Empty;
    }
}
}