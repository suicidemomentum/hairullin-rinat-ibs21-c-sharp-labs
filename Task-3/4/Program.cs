using GlobalUtils;
using LocalUtils;

Console.Write("Enter your string: ");
string s = GlobalClass.EnterString();

string b = LocalClass.NoRegexReplaceTags(s);
Console.WriteLine($"Result from no regex: {b}");

s = LocalClass.RegexReplaceTags(s);
Console.WriteLine($"Result from regex: {s}");

Console.ReadKey();