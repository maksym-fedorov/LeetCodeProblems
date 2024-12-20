﻿namespace LeetCode.Problems
{
    public sealed class SearchInsertPosition
    {
        public static int Run(int[] nums, int target)
        {
            System.ArgumentNullException.ThrowIfNull(nums);

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