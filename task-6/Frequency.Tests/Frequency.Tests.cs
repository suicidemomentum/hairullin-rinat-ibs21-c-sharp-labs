using static System.Net.Mime.MediaTypeNames;

namespace Frequency.Tests
{
    [TestClass]
    public class FrequencyTests
    {
        [DataTestMethod]
        [DataRow(new string[] { "Happy", "Holiday" }, "Happy Holiday. ")]
        [DataRow(new string[] { "Tomorrow", "will", "Be", "better", "day" }, "Tomorrow will. Be better. day")]
        [DataRow(new string[] { "Great", "Time", "Of", "Year" }, "  Great Time. Of.  .. Year")]
        public void Method_GetWordsArray_Tests(string[] target, string text)
        {
            string[] words = LocalClass.GetWordsArray(text);

            CollectionAssert.AreEqual(target, words);
        }

        [TestMethod]
        public void Method_CountFrequencyWords_Test()
        {
            Dictionary<string, int> target = new Dictionary<string, int>();
            target.Add("Great", 1);
            target.Add("Time", 1);
            target.Add("Of", 2);
            target.Add("Year", 3);

            string[] words = new string[] { "Great", "Time", "Of", "Year", "year", "of", "yeaR", };

            Dictionary<string, int> frequency = LocalClass.CountFrequencyWords(words);

            CollectionAssert.AreEqual(target, frequency);
        }
    }
}