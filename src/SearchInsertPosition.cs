namespace LeetCode.Problems
{
    internal sealed class SearchInsertPosition
    {
        public static int Method(int[] nums, int target)
        {
            if (nums is null)
            {
                throw new System.ArgumentNullException(nameof(nums));
            }

            if (nums.Length == 0)
            {
                return 0;
            }

            int l = 0;
            int r = nums.Length - 1;
            int m;

            while (l < r)
            {
                m = (l + r) / 2;

                if (nums[m] == target)
                {
                    return m;
                }
                else if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            return target <= nums[l] ? l : l + 1;
        }
    }
}