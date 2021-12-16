using System.Collections.Generic;

namespace LeetCode.Problems
{
    internal sealed class ValidParentheses
    {
        public static bool Method(string s)
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

                char pop;

                if (!stack.TryPop(out pop))
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