using System;
public class SyrupCappuccino : Cappuccino
{
    public new string name = "SyrupCappuccino";
    public SyrupType syrup;
    protected SyrupCappuccino(Intensity coffeeIntensity, SyrupType syrup) : base(coffeeIntensity) 
    { this.syrup = syrup;}
    public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Syrup for cappuccino : {this.syrup}");
  }
  public static SyrupCappuccino makeSyrupCappuccino()
  {
    Console.WriteLine("Choose Intensity from the list: (LIGHT, NORMAL, STRONG)");
    string intensityHere = Console.ReadLine();
    Console.WriteLine("Choose a syrup from the list: (MACADAMIA, VANILLA, COCONUT, CARAMEL, CHOCOLATE, POPCORN)");
    string syrupHere = Console.ReadLine();
    if (Enum.TryParse(intensityHere, true, out Intensity intensity) 
    && Enum.TryParse(syrupHere, true, out SyrupType syrupType))
    {
      Console.WriteLine($"Making a SyrupCappuccino");
      SyrupCappuccino syrupCappuccino = new SyrupCappuccino(intensity, syrupType);
      syrupCappuccino.printCoffeeDetails();
      return syrupCappuccino;
    }
      else return null;
  }
}