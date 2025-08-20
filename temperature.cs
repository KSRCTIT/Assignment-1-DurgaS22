using System;

class Temperature
{
    static void Main()
    {
        float temperature = 36.6f;
        if (temperature > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");
    }
}
