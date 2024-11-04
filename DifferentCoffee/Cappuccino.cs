using System;
public class Cappuccino : Coffee
{
  public new string name = "Cappuccino";
  public int mlOfMilk { get; set; } = 85;
  public Cappuccino(Intensity coffeeIntensity, int mlOfMilk = 85) : base(coffeeIntensity) { }
  public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Milk for cappuccino : {this.mlOfMilk}ml");
  }
}