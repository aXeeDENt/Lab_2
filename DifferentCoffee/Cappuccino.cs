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
  public static Cappuccino makeCappuccino()
  {
    Console.WriteLine("Choose Intensity from the list: (LIGHT, NORMAL, STRONG)");
    string intensityHere = Console.ReadLine();
    if (Enum.TryParse(intensityHere, true, out Intensity intensity))
    {Console.WriteLine($"Making a Cappuccino");
    Cappuccino cappuccino = new Cappuccino(intensity);
    cappuccino.printCoffeeDetails();
    return cappuccino;}
    else return null;
  }
}