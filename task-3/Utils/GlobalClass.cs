using System;

namespace GlobalUtils;

public static class GlobalClass
{
    public static string EnterString()
    {
        string? s = Console.ReadLine();
        if (string.IsNullOrEmpty(s))
        {
            Console.Write("You entered nothing!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        return s;
    }
}