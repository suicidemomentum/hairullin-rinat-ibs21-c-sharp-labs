using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static string[]? GetWordsArray(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }

        public static Dictionary<string, int> CountFrequencyWords(string[] words)
        {
            Dictionary<string, int> frequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                if (!frequency.ContainsKey(word))
                {
                    frequency.Add(word, 1);
                }
                else
                {
                    frequency[word]++;
                }
            }

            return frequency;
        }

        public static void PrintFrequencyWords(Dictionary<string, int> frequency)
        {
            var orderedFrequency = from f in frequency
                                   orderby f.Value descending
                                   select f;

            foreach (var item in orderedFrequency) //сортировка по linq
            {
                Console.WriteLine($"Word {item.Key} has {item.Value} entries!");
            }
        }
    }
}
