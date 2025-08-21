using System;

class ATM
{
    static void Main()
    {
        int correctPIN = 1234;
        int attempts = 0;
        bool granted = false;

        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int enteredPIN = Convert.ToInt32(Console.ReadLine());

            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                granted = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                attempts++;
            }
        }

        if (!granted)
            Console.WriteLine("Card Blocked");
    }
}
