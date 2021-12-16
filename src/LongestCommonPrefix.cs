namespace LeetCode.Problems
{
    internal sealed class LongestCommonPrefix
    {
        public static string Run(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            var maxPrefixLength = int.MaxValue;

            for (int i = 0; i < strs.Length; i++)
            {
                if (maxPrefixLength > strs[i].Length)
                {
                    maxPrefixLength = strs[i].Length;
                }
            }

            var prefix = new char[maxPrefixLength];

            for (int i = 0; i < maxPrefixLength; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != strs[0][i])
                    {
                        return new string(prefix, 0, i);
                    }
                }

                prefix[i] = strs[0][i];
            }

            return new string(prefix);
        }
    }
}