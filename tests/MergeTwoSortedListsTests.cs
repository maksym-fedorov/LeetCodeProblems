using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class MergeTwoSortedListsTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Run_ReturnsMergeOfTwoSortedLists(MergeTwoSortedLists.ListNode l1, MergeTwoSortedLists.ListNode l2, MergeTwoSortedLists.ListNode expected)
        {
            // Act
            var actual = MergeTwoSortedLists.Run(l1, l2);

            // Assert
            while (expected != null && actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);

                actual = actual.next;
                expected = expected.next;
            }

            Assert.IsNull(expected);
            Assert.IsNull(actual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // Arrange #0
            yield return new object[] 
            {
                null,
                null,
                null
            };

            // Arrange #1
            yield return new object[] 
            {
                null,
                new MergeTwoSortedLists.ListNode(1, new(3, new(4))),
                new MergeTwoSortedLists.ListNode(1, new(3, new(4))),
            };

            // Arrange #2
            yield return new object[] 
            {
                new MergeTwoSortedLists.ListNode(1, new(2)), 
                null, 
                new MergeTwoSortedLists.ListNode(1, new(2)),
            };

            // Arrange #3
            yield return new object[] 
            {
                new MergeTwoSortedLists.ListNode(1, new(2)), 
                new MergeTwoSortedLists.ListNode(1, new(2, new(3, new(4)))),
                new MergeTwoSortedLists.ListNode(1, new(1, new(2, new(2, new(3, new(4)))))),
            };
        }
    }
}