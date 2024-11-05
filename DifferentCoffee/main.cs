using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Barista barista = new Barista();
        List<Coffee> orderList = barista.TakeOrder();
        // Coffee coffee = new Coffee(Intensity.LIGHT); 
    }
}
