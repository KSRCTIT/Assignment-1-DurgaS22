using System;

class Program
{
    static void Main()
    {
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A scored more than B: " + (playerA > playerB));
        Console.WriteLine("Scores are equal: " + (playerA == playerB));
        Console.WriteLine("Any player failed to beat the other: " + (playerA <= playerB || playerB <= playerA));
    }
}
