namespace LeetCode.Problems
{
    public sealed class RunningSumOf1dArray
    {
        public static int[] Run(int[] nums)
        {
            var output = new int[nums.Length];

            output[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                output[i] = output[i - 1] + nums[i];
            }

            return output;
        }
    }
}