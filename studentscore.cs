using System;

class StudentScores
{
    static double CalculateAverage(int[] marks)
    {
        int sum = 0;
        foreach (int mark in marks)
            sum += mark;
        return sum / 5.0;
    }

    static void Main()
    {
        int[] marks = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter mark for subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        double avg = CalculateAverage(marks);
        Console.WriteLine("Average: " + avg);

        if (avg >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");
    }
}
