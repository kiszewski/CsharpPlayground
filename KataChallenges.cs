using System.Linq;

public static partial class Kata
{
    public static bool IsSquare(int n)
    {
        var r = Math.Sqrt(n);
        return Math.Truncate(r) == r;
    }

    public static int sumTwoSmallestNumbers(int[] n)
    {
        var numbers = new List<int>(n);
        numbers.Sort((int v1, int v2) => v1 > v2 ? 1 : -1);

        return numbers[0] + numbers[1];
    }

    public static string FirstNonRepeatingLetter(string s)
    {
        var response = "";


        foreach (var item in s)
        {
            var repeteadChars = s.Where(c => char.ToLower(c) == char.ToLower(item));

            if (repeteadChars.Count() == 1)
            {
                response = item.ToString();
                break;
            }
        }

        return response;
    }

    public static int[] TwoSum(int[] numbers, int target)
    {
        var response = new List<int>();

        var originalNumbers = new List<int>(numbers);

        for (int index1 = 0; index1 < (numbers.Length - 1); index1++)
        {
            if (response.Count() > 0) break;

            var actual = numbers[index1];
            numbers[index1] = Random.Shared.Next();

            var filtered = numbers.Where(v =>
            {
                var sum = v + actual;
                return sum == target;
            });

            if (filtered?.Count() > 0)
            {
                var index2 = Array.IndexOf(numbers, filtered.First());

                response.Add(index1);
                response.Add(index2);

                return response.ToArray();
            }
        }

        return new int[0];
    }

    public static string TitleCase(string title, string minorWords = "")
    {
        if (minorWords == null) minorWords = "";
        var words = title.ToLower().Split(' ');
        var minorWordsList = minorWords.ToLower().Split(' ');

        var count = 0;
        var wordsCapitlized = words.Select((w) =>
        {
            var isFirst = count == 0;
            var shouldCapitilize = isFirst || !minorWordsList.Contains(w);

            count++;

            return shouldCapitilize ? Capitalize(w) : w;
        });

        return string.Join(' ', wordsCapitlized);
    }

    private static string Capitalize(string text)
    {
        if (String.IsNullOrEmpty(text)) return text;

        var chars = text.ToCharArray();
        chars[0] = Char.ToUpper(text[0]);

        return new String(chars);
    }

    public static bool ValidParentheses(string input)
    {
        var leftCount = input.Where(c => c == '(').Count();
        var rightCount = input.Where(c => c == ')').Count();
        if (leftCount != rightCount) return false;

        var isSorted = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (!isSorted) return false;

            var currentChar = input[i];

            if (currentChar == '(')
            {
                var subInput = input.Substring(i + 1);
                var left = subInput.Where(c => c == '(').Count();
                var right = subInput.Where(c => c == ')').Count();

                isSorted = subInput.Contains(')') && (right - left > 0);
            }
            if (currentChar == ')')
            {
                var subInput = input.Substring(0, i);
                var left = subInput.Where(c => c == '(').Count();
                var right = subInput.Where(c => c == ')').Count();

                isSorted = subInput.Contains('(') && (left - right > 0);
            }
        }

        return isSorted;
    }

    public static string ToWeirdCase(string s)
    {
        var newWords = s.Split(' ')
        .Select((w) => w.Select((c, i) => i % 2 == 0 ? Char.ToUpper(c) : Char.ToLower(c)))
        .Select((w) => string.Concat(w));

        return string.Join(' ', newWords);
    }

    public static long digPow(int n, int p)
    {
        var sumOfPows = 0.0;
        var exponential = p;
        var numberString = n.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            var currentNum = int.Parse(numberString[i].ToString());

            sumOfPows += Math.Pow(currentNum, exponential);

            exponential++;
        }

        var result = sumOfPows / n;

        return (int)result == result ? (int)result : -1;
    }

    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        var dict = new Dictionary<string, List<int>>
        {
            ["pos"] = new List<int> { },
            ["peaks"] = new List<int> { },
        };

        for (int i = 0; i < arr.Length; i++)
        {
            var isNotFirstAndLast = i != 0 && i != (arr.Length - 1);

            if (isNotFirstAndLast)
            {
                var current = arr[i];
                var previous = arr[i - 1];
                var next = arr[i + 1];

                var currentBiggerThanPrevious = current > previous;
                var currentBiggerThanNext = current > next;
                var currentEqualsNext = current == next;

                var isPeak = currentBiggerThanPrevious && currentBiggerThanNext;

                if (currentBiggerThanPrevious && currentEqualsNext)
                {
                    var nextCount = i + 1;

                    while (nextCount <= arr.Length - 1)
                    {
                        if (arr[nextCount] < next)
                        {
                            isPeak = true;
                            break;
                        }

                        if (arr[nextCount] > next)
                        {
                            isPeak = false;
                            break;
                        }

                        nextCount++;
                    }
                }

                if (isPeak)
                {
                    dict["pos"].Add(i);
                    dict["peaks"].Add(current);
                }
            }
        }

        return dict;
    }

}

