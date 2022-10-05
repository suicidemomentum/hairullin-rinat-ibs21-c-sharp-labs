using System.Xml.Linq;
using GlobalUtils;
using LocalUtils;

Console.Write("Enter your string: ");
string s = GlobalClass.EnterString();

string[] mas = LocalClass.GetSplittedString(s);
double averageLength = LocalClass.GetAverageWordLength(mas);

Console.WriteLine("Average words length: " + averageLength);
Console.ReadKey();