using System;

namespace LeetCode.Problems
{
    public sealed class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return;
            }

            if (m == 0)
            {
                Array.Copy(nums2, nums1, n);
                return;
            }

            var nums3 = new int[m + n];

            int i1 = 0;
            int i2 = 0;
            int i3 = 0;

            while (i1 < m && i2 < n)
            {
                if (nums1[i1] <= nums2[i2])
                {
                    nums3[i3] = nums1[i1];
                    i1++;
                    i3++;
                }
                else
                {
                    nums3[i3] = nums2[i2];
                    i2++;
                    i3++;
                }
            }

            if (i1 == m)
            {
                Array.Copy(nums2, i2, nums3, i3, n - i2);
            }
            else if (i2 == n)
            {
                Array.Copy(nums1, i1, nums3, i3, m - i1);
            }

            Array.Copy(nums3, nums1, m + n);
        }
    }
}
