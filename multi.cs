using System;

class MultiplicationTable
{
    static void Main()
    {
        char choice;
        do
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(num + " x " + i + " = " + (num * i));

            Console.Write("Do you want to try another number? (Y/N): ");
            choice = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (choice == 'Y');
    }
}
