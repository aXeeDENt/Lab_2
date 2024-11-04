using System;
public class Americano : Coffee
{
  public new string name = "Americano";
  public int mlofWater;
  public Americano(Intensity coffeeIntensity, int mlofWater) : base(coffeeIntensity) { this.mlofWater = mlofWater; }
  public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Water for americano : {this.mlofWater}ml");
  }
}
