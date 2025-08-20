using System;

class Program
{
    static void Main()
    {
        double price = 1000.0, discount = 10.0;
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
