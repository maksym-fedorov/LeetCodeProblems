using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class MergeSortedArrayTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Merge_ShouldMatchExpected(int[] nums1, int nums1Size, int[] nums2, int nums2Size, int[] expected)
        {
            // Arrange
            // Act
            MergeSortedArray.Merge(nums1, nums1Size, nums2, nums2Size);

            // Assert
            CollectionAssert.AreEqual(nums1, expected);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 } };
            yield return new object[] { new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 } };
            yield return new object[] { new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 } };
            yield return new object[] { new int[] { 4, 0, 0, 0, 0, 0 }, 1, new int[] { 1, 2, 3, 5, 6 }, 5, new int[] { 1, 2, 3, 4, 5, 6 } };
        }
    }
}