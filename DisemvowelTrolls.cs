using System;
using System.Linq;

public static partial class Kata
{

    public static string Disemvowel(string str)
    {
        var notVowels = str.Where(isNotVowel);

        var r = "";

        foreach (var item in notVowels)
        {
            r += item.ToString();
        }

        return r;
    }

    private static bool isNotVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] vowelsUpper = { 'A', 'E', 'I', 'O', 'U' };

        var isVowel = vowels.Contains(c) || vowelsUpper.Contains(c);

        return !isVowel;
    }
}