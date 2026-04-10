using LeetCode.Problems.TwoPointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Tests.TwoPointers
{
    [TestClass]
    public sealed class ThreeSumTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData))]
        public void Run_ReturnsTripletsWithZeroSum(int[] nums, IList<IList<int>> expected)
        {
            // Arrange
            var sut = new ThreeSum();

            // Act
            var actual = sut.Run(nums);

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);

            var expectedSorted = expected.Select(t => t.OrderBy(x => x).ToList()).OrderBy(t => string.Join(",", t)).ToList();
            var actualSorted = actual.Select(t => t.OrderBy(x => x).ToList()).OrderBy(t => string.Join(",", t)).ToList();

            for (int i = 0; i < expectedSorted.Count; i++)
            {
                CollectionAssert.AreEqual(expectedSorted[i], actualSorted[i]);
            }
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // [-1,0,1,2,-1,-4] → [[-1,-1,2],[-1,0,1]]
            yield return new object[]
            {
                new int[] { -1, 0, 1, 2, -1, -4 },
                new List<IList<int>>
                {
                    new List<int> { -1, -1, 2 },
                    new List<int> { -1, 0, 1 }
                }
            };

            // [0,1,1] → []
            yield return new object[]
            {
                new int[] { 0, 1, 1 },
                new List<IList<int>>()
            };

            // [0,0,0] → [[0,0,0]]
            yield return new object[]
            {
                new int[] { 0, 0, 0 },
                new List<IList<int>> { new List<int> { 0, 0, 0 } }
            };

            // [0,0,0,0] → [[0,0,0]]
            yield return new object[]
            {
                new int[] { 0, 0, 0, 0 },
                new List<IList<int>> { new List<int> { 0, 0, 0 } }
            };

            // [1,-1,0,2,-2,0] → [[-2,0,2],[-1,0,1]]
            yield return new object[]
            {
                new int[] { 1, -1, 0, 2, -2, 0 },
                new List<IList<int>>
                {
                    new List<int> { -2, 0, 2 },
                    new List<int> { -1, 0, 1 }
                }
            };

            // [-100,-70,-60,110,120,130,160] → [[-100,-60,160],[-70,-60,130]]
            yield return new object[]
            {
                new int[] { -100, -70, -60, 110, 120, 130, 160 },
                new List<IList<int>>
                {
                    new List<int> { -100, -60, 160 },
                    new List<int> { -70, -60, 130 }
                }
            };
        }
    }
}
