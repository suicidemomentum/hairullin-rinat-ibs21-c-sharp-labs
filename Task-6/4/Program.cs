string input = "123";
bool isPositiveInteger = input.IsPositiveInteger();
Console.WriteLine("Is positive integer: " + isPositiveInteger);

public static class StringExtension //any class name is acceptable
{
    public static bool IsPositiveInteger(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return false;
        }

        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}