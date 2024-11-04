 namespace OOP_Labs.Lab_2.DifferentCoffee
 {
   public class Cappuccino : Coffee
   {
      public new string name = "Cappuccino";
      public int mlOfMilk;
      public Cappuccino(Intensity coffeeIntensity, int mlOfMilk) : base(coffeeIntensity) { this.mlOfMilk = mlOfMilk; }
   }
 }