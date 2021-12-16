using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    internal sealed class TwoSum
    {
        public static ValueTuple<int, int> Method(int[] nums, int target)
        {
            var valuesIndicies = new Dictionary<int, int>();

            int dif;

            for (int i = 0; i < nums.Length; i++)
            {
                dif = target - nums[i];

                if (valuesIndicies.ContainsKey(dif))
                {
                    return ValueTuple.Create(valuesIndicies[dif], i);
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