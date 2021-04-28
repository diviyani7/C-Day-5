using System.IO;
using System;
public class FirstInterface
{
    public interface IVehiculoInterface 
{
  void Drive(); // interface method
  bool Refuel(int amount);
}
public class Car:IVehiculoInterface
{
 public int Fuel{get; set;}
 public Car(int fuel)
 {
     Fuel=fuel;
 }
 public void Drive()
 {
     if(Fuel >0)
     {
         Console.WriteLine("The Car is Driving");
     }
     else
     {
        Console.WriteLine("No fuel");

     }
 }
 public bool Refuel(int amount)
 {
     Fuel=Fuel+amount;
     return true;
 }
}
static void Main()
{
Car car = new Car(0);
Console.WriteLine("Enter the fuel amount: ");
int fuel =int.Parse(Console.ReadLine());
if (car.Refuel(fuel))
{
    car.Drive();
}
}
}