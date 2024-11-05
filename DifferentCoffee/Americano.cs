using System;
public class Americano : Coffee
{
  public new string name = "Americano";
  public int mlofWater { get; set; } = 180;
  protected Americano(Intensity coffeeIntensity, int mlofWater = 180) : base(coffeeIntensity) { }
  public override void printCoffeeDetails()
  {
    base.printCoffeeDetails();
    Console.WriteLine($"Water for americano : {this.mlofWater}ml");
  }
  public static Americano makeAmericano()
  {
    Console.WriteLine("Choose Intensity from the list: (LIGHT, NORMAL, STRONG)");
    string intensityHere = Console.ReadLine();
    if (Enum.TryParse(intensityHere, true, out Intensity intensity))
    {
      Console.WriteLine($"Making a Americano");
      Americano americano = new Americano(intensity);
      americano.printCoffeeDetails();
      return americano;
    }
    else return null;
  }
}
