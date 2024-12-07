using System.Collections.Generic;

namespace LeetCode.Problems
{
    public sealed class CountAndSay
    {
        public static string Run(int n)
        {
            var terms = new List<string>() { "1" };

            for (int i = 2; i <= n; i++)
            {
                var c = terms[i - 2][0];
                var count = 1;
                var term = "";

                for (int j = 1; j < terms[i - 2].Length; j++)
                {
                    if (c == terms[i - 2][j])
                    {
                        count++;
                    }
                    else
                    {
                        term += $"{count}{c}";
                        c = terms[i - 2][j];
                        count = 1;
                    }
                }

                term += $"{count}{c}";

                terms.Add(term);
            }

            return terms[n - 1];
        }
    }
}