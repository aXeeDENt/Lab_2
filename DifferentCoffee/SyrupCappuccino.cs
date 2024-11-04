using System;
public class SyrupCappuccino : Cappuccino
{
    public new string name = "SyrupCappuccino";
    public SyrupType syrup;
    public SyrupCappuccino(Intensity coffeeIntensity, SyrupType syrup) : base(coffeeIntensity) 
    { this.syrup = syrup;}
    public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Syrup for cappuccino : {this.syrup}");
  }
}