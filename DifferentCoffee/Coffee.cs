using System;

public class Coffee 
{
    public Intensity coffeeIntensity;
    public const string name = "Coffee";

    protected Coffee(Intensity coffeeIntensity) 
    { 
        this.coffeeIntensity = coffeeIntensity; 
    }

    public virtual void printCoffeeDetails()
    {
      Console.WriteLine($"Coffee intensity is: {this.coffeeIntensity}");
    }

    public static Coffee makeCoffee()
    {
      Console.WriteLine("Choose Intensity from the list: (LIGHT, NORMAL, STRONG)");
      string intensityHere = Console.ReadLine();
      if (Enum.TryParse(intensityHere, true, out Intensity intensity))
      {
        Console.WriteLine($"Making a Coffee");
        Coffee coffee = new Coffee(intensity);
        coffee.printCoffeeDetails();
        return coffee;
      }
      else return null;    
    }
}
