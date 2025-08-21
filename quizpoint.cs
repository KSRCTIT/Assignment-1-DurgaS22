using System;

class QuizPoints
{
    static void Main()
    {
        int score = 50;
        Console.WriteLine("Starting score: " + score);

        score += 10; // correct answer
        Console.WriteLine("After correct answer: " + score);

        score -= 5; // wrong answer
        Console.WriteLine("After wrong answer: " + score);

        score *= 2; // bonus round
        Console.WriteLine("After bonus round: " + score);

        score /= 5; // penalty
        Console.WriteLine("After penalty: " + score);
    }
}
