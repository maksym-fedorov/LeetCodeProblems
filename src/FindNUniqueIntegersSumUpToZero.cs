namespace LeetCode.Problems
{
    internal sealed class FindNUniqueIntegersSumUpToZero
    {
        public static int[] Run(int n)
        {
            var result = new int[n];

            for (int i = 0; i < n / 2; i++)
            {
                result[i] = -(i + 1);
                result[n - i - 1] = i + 1;
            }

            return result;
        }
    }
}