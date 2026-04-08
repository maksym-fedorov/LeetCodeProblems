using System.Collections.Generic;

namespace LeetCode.Problems.SlidingWindow
{
    public sealed class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            { 
                return 0;
            }

            var charSet = new HashSet<char>();
            int left = 0, right = 0, maxLength = 0;
            
            while (right < s.Length)
            {
                if (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }
                else
                {
                    charSet.Add(s[right]);
                    right++;
                }

                maxLength = System.Math.Max(maxLength, charSet.Count);
            }

            return maxLength;
        }
    }
}
