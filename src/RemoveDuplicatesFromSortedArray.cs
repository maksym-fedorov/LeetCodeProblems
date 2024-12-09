namespace LeetCode.Problems
{
    public sealed class RemoveDuplicatesFromSortedArray
    {
        public static int Run(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var result = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[result - 1] != nums[i])
                {
                    nums[result] = nums[i];
                    result++;
                }
            }

            return result;
        }
    }
}