using System;

namespace LeetCode.Problems.Math
{
    public sealed class PlusOne
    {
        public int[] Run(int[] digits)
        {
            int sum = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                sum = digits[i] + 1;
                if (sum > 9)
                {
                    digits[i] = sum - 10;
                    sum = 1;
                }
                else
                {
                    digits[i] = sum;
                    sum = 0;
                    break;
                }
            }

            if (sum == 0)
            {
                return digits;
            }

            var result = new int[digits.Length + 1];
            result[0] = sum;
            Array.Copy(digits, 0, result, 1, digits.Length);

            return result;
        }
    }
}
