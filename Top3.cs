using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class TopWords
{
    public static List<string> Top3(string s)
    {
        var splitted = s.Split(' ');

        var words = new Dictionary<string, int> { };

        foreach (var item in splitted)
        {
            var isWord = item.Any(char.IsLetter);

            if (!isWord) continue;

            string pattern = "[^a-zA-Z']";
            var wordClean = Regex.Replace(item, pattern, "").ToLower();

            if (words.ContainsKey(wordClean))
            {
                var count = words[wordClean];

                words[wordClean] = count + 1;
            }
            else
            {
                words[wordClean] = 1;
            }

        }

        var ordered = words.OrderByDescending((v) => v.Value);

        return ordered.Take(3).Select(c => c.Key).ToList();
    }
}