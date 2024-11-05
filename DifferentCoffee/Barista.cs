using System;
using System.Collections.Generic;

public class Barista 
{
    public List<Coffee> TakeOrder()
    {
        List<Coffee> orderList = new List<Coffee>();
        Console.WriteLine("How many coffee would you like to order?");
        if (int.TryParse(Console.ReadLine(), out int count))
        {
            Console.WriteLine("\nSelect coffee from the list: \n 1. Simple Coffee \n 2. Americano \n 3. Cappuccino \n 4. Syrup Cappuccino \n 5. Pumpkin Spice Latte \n");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nYour choice: ");
                Coffee coffee = null;
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        coffee = Coffee.makeCoffee();
                        break;
                    case "2":
                        coffee = Americano.makeAmericano();
                        break;
                    case "3":
                        coffee = Cappuccino.makeCappuccino();
                        break;
                    case "4":
                        coffee = SyrupCappuccino.makeSyrupCappuccino();
                        break;
                    case "5":
                        coffee = PumpkinSpiceLatte.makePumpkinSpiceLatte();
                        break;
                    default:
                        Console.WriteLine("Invalid choice of coffee.");
                        break;
                }
                    
                if (coffee != null) { orderList.Add(coffee); }
            }
        }
        else { Console.WriteLine("Invalid input for number of coffees."); }
        return orderList;
    }
}