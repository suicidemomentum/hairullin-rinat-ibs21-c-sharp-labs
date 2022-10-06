using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static string RegexReplaceTags(string s)
        {
            string pattern = @"(\<([^\>]+)\>)";
            string target = "_";

            Regex regex = new Regex(pattern);

            return regex.Replace(s, target);
        }

        internal static string NoRegexReplaceTags(string s) //не работает
        {
            string[] words = s.Split(new char[] { '>', '<' }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result += "_" + words[i];
                }
            }

            return result;
        }
    }
}
