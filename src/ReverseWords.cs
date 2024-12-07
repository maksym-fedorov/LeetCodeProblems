namespace LeetCode.Problems
{
    public sealed class ReverseWords
    {
        public static string Run(string s)
        {
            var result = new char[s.Length];

            var stringIndex = 0;
            var wordStart = 0;

            while (stringIndex <= result.Length)
            {
                if (stringIndex == result.Length || s[stringIndex] == ' ')
                {
                    for (var wordIndex = wordStart; wordIndex <= stringIndex - 1; wordIndex++)
                    {
                        result[wordIndex] = s[wordStart + stringIndex - 1 - wordIndex];
                    }

                    if (stringIndex < result.Length)
                    {
                        result[stringIndex] = ' ';
                    }

                    wordStart = stringIndex + 1;
                }

                stringIndex++;
            }

            return new string(result);
        }
    }
}