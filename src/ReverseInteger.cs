using System;

namespace LeetCode.Problems
{
    public sealed class ReverseInteger
    {
        public static int Run(int x)
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