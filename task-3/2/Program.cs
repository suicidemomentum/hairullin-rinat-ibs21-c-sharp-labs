using LocalUtils;
using GlobalUtils;

Console.Write("Enter your string: ");
string s = GlobalClass.EnterString();

s = LocalClass.NormalizeString(s);

if (LocalClass.IsStringPalindrome(s))
{
    Console.WriteLine("Entered string is a palindrome");
}
else
{
    Console.WriteLine("Entered string is not a palindrome");
}

Console.ReadKey();