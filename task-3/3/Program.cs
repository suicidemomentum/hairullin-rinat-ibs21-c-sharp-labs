using LocalUtils;
using GlobalUtils;

Console.Write("Enter your email: ");
string s = GlobalClass.EnterString();

if (LocalClass.IsStringEmail(s))
{
    Console.WriteLine($"Entered string {s} is email format");
}
else
{
    Console.WriteLine($"Entered string {s} is not email format");
}

Console.ReadKey();