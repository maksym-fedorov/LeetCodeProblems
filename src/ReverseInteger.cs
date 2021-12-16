using System;

namespace LeetCode.Problems
{
    internal sealed class ReverseInteger
    {
        public static int Method(int x)
        {
            var result = 0;

            try
            {
                while (x != 0)
                {
                    result = checked(result * 10 + x % 10);

                    x /= 10;
                }
            }
            catch (OverflowException)
            {
                return 0;
            }

            return result;
        }
    }
}