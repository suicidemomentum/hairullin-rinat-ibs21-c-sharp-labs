using LocalUtils;

const string message = "An empty string or something similar won't do, bye!";

string text = "Spongebob spongebob spongebob spongEbob PATRiCK PATRICK PATRICK. SQUIDWARD MRKRABS pLANKTON PLANKTON SANDY.";
if (string.IsNullOrWhiteSpace(text))
{
    Console.WriteLine(message);
    return;
}

string[] words = LocalClass.GetWordsArray(text);
if (words.Length == 0)
{
    Console.WriteLine(message);
    return;
}

Dictionary<string, int> frequency = LocalClass.CountFrequencyWords(words);
LocalClass.PrintFrequencyWords(frequency);