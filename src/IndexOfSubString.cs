namespace LeetCode.Problems
{
    public sealed class IndexOfSubstring
    {
        public static int Run(string haystack, string needle)
        {
            // KMP
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            var t = new int[needle.Length];

            t[0] = 0;

            int i = 0;
            int j = 1;

            while (j < needle.Length)
            {
                if (needle[j] == needle[i])
                {
                    t[j] = i + 1;
                    i++;
                    j++;
                }
                else if (i == 0)
                {
                    t[j] = 0;
                    j++;
                }
                else
                {
                    i = t[i - 1];
                }
            }

            i = 0;
            j = 0;

            while (j < needle.Length && i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j > 0)
                    {
                        j = t[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return j == needle.Length ? i - needle.Length : -1;
        }
    }
}