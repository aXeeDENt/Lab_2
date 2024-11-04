using System;
public class Coffee 
{
  public Intensity coffeeIntensity;
  public const string name = "Coffee";
  public Coffee(Intensity coffeeIntensity) 
  { this.coffeeIntensity = coffeeIntensity; }
  public virtual void printCoffeeDetails()
  { Console.WriteLine($"Coffee intensity is: {this.coffeeIntensity}"); }
}
   