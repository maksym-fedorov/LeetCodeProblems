namespace LeetCode.Problems
{
    internal sealed class RemoveElementFromArray
    {
        public static int Run(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int count = nums[0] == val ? 1 : 0;

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i - count] = nums[i];

                if (nums[i] == val)
                {
                    count++;
                }
            }

            return nums.Length - count;
        }
    }
}