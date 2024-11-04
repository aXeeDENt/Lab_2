using System;
public class PumpkinSpiceLatte : Coffee
{
  public new string name = "PumpkinSpiceLatte";
  public int mlOfMilk;
  public int mgOfPumpkinSpice;
  public PumpkinSpiceLatte(Intensity coffeeIntensity, int mlOfMilk, int mgOfPumpkinSpice) : base(coffeeIntensity) 
  { this.mlOfMilk = mlOfMilk; this.mgOfPumpkinSpice = mgOfPumpkinSpice;}
  public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Milk for latte : {this.mlOfMilk}ml");
    Console.WriteLine($"Pumpkin Spice amount : {this.mgOfPumpkinSpice}mg");
  }
}