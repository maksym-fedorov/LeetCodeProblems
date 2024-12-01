using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public sealed class TwoSum
    {
        public static ValueTuple<int, int> Run(int[] nums, int target)
        {
            var valuesIndicies = new Dictionary<int, int>();

            int dif;

            for (int i = 0; i < nums.Length; i++)
            {
                dif = target - nums[i];

                if (valuesIndicies.TryGetValue(dif, out int value))
                {
                    return ValueTuple.Create(value, i);
                }

                if (valuesIndicies.ContainsKey(nums[i]))
                {
                    continue;
                }

                valuesIndicies.Add(nums[i], i);
            }

            throw new ArgumentException("Incorrect input data");
        }
    }
}