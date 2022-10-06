using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LocalUtils
{
    internal static class LocalClass //группы доделать все в 1 методе глянуть в отладке объекты
    {
        internal static string[] RegexGetDates(string s)
        {
            Regex regex = new Regex(@"(([0-9]{2})\-([0-9]{2})\-([0-9]{4}))");
            MatchCollection matches = regex.Matches(s);

            string[] dates = new string[matches.Count];

            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    dates[i] = matches[i].Value;
                }
            }

            return dates;
        }

        internal static string[][] RegexGetDaysMonthsYears(string[] dates)
        {
            string[][] arrayOfArrays = new string[dates.Length][];

            for (int i = 0; i < dates.Length; i++)
            {
                arrayOfArrays[i] = new string[4];

                Regex regex = new Regex(@"(.*)\-(.*)\-(.*)");
                Match matches = regex.Match(dates[i]);

                arrayOfArrays[i][0] = dates[i];

                for (int j = 1; j < 4; j++)
                {
                    arrayOfArrays[i][j] = matches.Groups[j].Value;
                }
            }

            return arrayOfArrays;
        }

        internal static void PrintDaysMonthsYears(string[][] arrayOfArrays)
        {
            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                string message = $"{arrayOfArrays[i][0]}, where day is = {arrayOfArrays[i][1]}";
                message += $", month is = {arrayOfArrays[i][2]}, year is = {arrayOfArrays[i][3]}";
                Console.WriteLine(message);
            }
        }
    }
}
