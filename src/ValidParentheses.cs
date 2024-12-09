using System.Collections.Generic;

namespace LeetCode.Problems
{
    public sealed class ValidParentheses
    {
        public static bool Run(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);

                    continue;
                }

                if (!stack.TryPop(out char pop))
                {
                    return false;
                }

                if (s[i] == ')' && pop != '(')
                {
                    return false;
                }

                if (s[i] == '}' && pop != '{')
                {
                    return false;
                }

                if (s[i] == ']' && pop != '[')
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}