using System;

namespace LeetCode.Problems
{
    public sealed class PalindromeNumber
    {
        public static bool Run(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var result = 0;
            var temp = x;

            try
            {
                while (temp != 0)
                {
                    result = checked(result * 10 + temp % 10);

                    temp /= 10;
                }
            }
            catch (OverflowException)
            {
                return false;
            }

            return result == x;
        }
    }
}