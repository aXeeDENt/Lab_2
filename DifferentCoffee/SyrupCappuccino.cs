 namespace OOP_Labs.Lab_2.DifferentCoffee
 {
    public class SyrupCappuccino : Cappuccino
    {
        public new string name = "SyrupCappuccino";
        SyrupType syrup;
        public SyrupCappuccino(Intensity coffeeIntensity, int mlOfMilk, SyrupType syrup) : base(coffeeIntensity,mlOfMilk) 
        { this.syrup = syrup;}
    }
 }