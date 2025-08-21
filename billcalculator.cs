using System;

class ElectricityBill
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        int rate;

        if (units <= 100)
            rate = 2;
        else if (units <= 200)
            rate = 3;
        else
            rate = 5;

        int bill = units * rate;
        Console.WriteLine("Total Bill: ₹" + bill);
    }
}
