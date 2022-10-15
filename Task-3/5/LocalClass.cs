using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static string[] RegexGetDates(string s) //change regex
        {
            string pattern = @"(?<d>0[1-9]|[1-2][0-9]|3[0-1])-(?<m>0[1-9]|1[0-2])-" +
                            @"(?<y>[0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]|[0-9][1-9][0-9]{2}|[1-9][0-9]{3})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(s);

            string[] dates = new string[matches.Count];

            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    dates[i] = $"{matches[i].Value}:{matches[i].Groups["d"]}:{matches[i].Groups["m"]}:{matches[i].Groups["y"]}";
                }
            }

            return dates;
        }

        internal static void PrintDatesInfo(string[] dates)
        {
            for (int i = 0; i < dates.Length; i++)
            {
                string[] info = dates[i].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                string message = $"{info[0]}, where day is = {info[1]}";
                message += $", month is = {info[2]}, year is = {info[3]}";
                Console.WriteLine(message);
            }
        }
    }
}
