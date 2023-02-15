public static partial class Kata
{
    public static string AlphabetPosition(string text)
    {
        var result = "";

        foreach (var item in text.ToLower())
        {
            var byteValue = ((byte)item);
            var isOutOfAlphabet = byteValue < 97 || byteValue > 122;

            if (isOutOfAlphabet) continue;

            result += $"{(byteValue - 96)} ";
        }

        return result.TrimEnd();
    }
}