using System;
public class PumpkinSpiceLatte : Coffee
{
  public new string name = "PumpkinSpiceLatte";
  public int mlOfMilk;
  public int mgOfPumpkinSpice;
  public PumpkinSpiceLatte(Intensity coffeeIntensity,  int mgOfPumpkinSpice, int mlOfMilk = 200) : base(coffeeIntensity) 
  { this.mgOfPumpkinSpice = mgOfPumpkinSpice;}
  public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Milk for latte : {this.mlOfMilk}ml");
    Console.WriteLine($"Pumpkin Spice amount : {this.mgOfPumpkinSpice}mg");
  }
  public static PumpkinSpiceLatte makePumpkinSpiceLatte()
  {
    Console.WriteLine("Choose Intensity from the list: (LIGHT, NORMAL, STRONG)");
    string intensityHere = Console.ReadLine();
    Console.WriteLine("Input amount of Pumpkin Spice (recommend 15-75mg)");
    string pumpkinSpiceHere = Console.ReadLine();
    if (Enum.TryParse(intensityHere, true, out Intensity intensity) 
    && Enum.TryParse(pumpkinSpiceHere, true, out int pumpkinSpiceNew))
    {
      Console.WriteLine($"Making a PumpkinSpiceLatte");
      PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(intensity, pumpkinSpiceNew);
      pumpkinSpiceLatte.printCoffeeDetails();
      return pumpkinSpiceLatte;
    }
      else return null;
  }
}