using GlobalUtils;
using LocalUtils;

Console.Write("Enter your string: ");
string s = GlobalClass.EnterString();

string[] dates = LocalClass.RegexGetDates(s);
if (dates.Length == 0)
{
    Console.WriteLine("No dates has been found by regex");
}

string[][] arrayOfArrays = LocalClass.RegexGetDaysMonthsYears(dates);
LocalClass.PrintDaysMonthsYears(arrayOfArrays);