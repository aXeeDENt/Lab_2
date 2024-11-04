 namespace OOP_Labs.Lab_2.DifferentCoffee
 {
   public class Americano : Coffee
   {
      public new string name = "Americano";
      public int mlofWater;
      public Americano(Intensity coffeeIntensity, int mlofWater) : base(coffeeIntensity) { this.mlofWater = mlofWater; }
   }
 }