using System;

class Program
{
    static void Main(string[] args)
    {
        SyrupCappuccino coffee_order_1 = new SyrupCappuccino(Intensity.STRONG,SyrupType.CARAMEL);
        coffee_order_1.printCoffeeDetails();
    }
}
