 namespace OOP_Labs.Lab_2.DifferentCoffee
 {
   public class PumpkinSpiceLatte : Coffee
   {
      public new string name = "PumpkinSpiceLatte";
      public int mlOfMilk;
      public int mgOfPumpkinSpice;
      public PumpkinSpiceLatte(Intensity coffeeIntensity, int mlOfMilk, int mgOfPumpkinSpice) : base(coffeeIntensity) 
      { this.mlOfMilk = mlOfMilk; this.mgOfPumpkinSpice = mgOfPumpkinSpice;}
   }
 }