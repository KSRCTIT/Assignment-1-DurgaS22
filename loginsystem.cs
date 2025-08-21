using System;

class Program
{
    static void Main()
    {
        string username = "admin", password = "1234";
        bool isUsernameValid = username == "admin";
        bool isPasswordValid = password == "1234";

        Console.WriteLine("Login successful using &&: " + (isUsernameValid && isPasswordValid));
        Console.WriteLine("At least one correct using ||: " + (isUsernameValid || isPasswordValid));
    }
}
