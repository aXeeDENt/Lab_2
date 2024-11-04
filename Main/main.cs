using System;
using OOP_Labs.Lab_2.DifferentCoffee;
public class Program
{
    static void Main(string[] args)
    {
        Coffee coffee = new Coffee(coffeeIntensity.NORMAL);
        Console.WriteLine(coffee.coffeeIntensity);

        Cappuccino cappuccino = new Cappuccino(coffeeIntensity.STRONG, 150);
        Console.WriteLine(cappuccino.coffeeIntensity);
    }
}