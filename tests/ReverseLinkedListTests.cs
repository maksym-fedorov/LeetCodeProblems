using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class ReverseLinkedListTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void ReverseList_ReturnsReversedList(ReverseLinkedList.ListNode node, ReverseLinkedList.ListNode expected)
        {
            // Act
            var actual = ReverseLinkedList.ReverseList(node);

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
                default(ReverseLinkedList.ListNode),
                default(ReverseLinkedList.ListNode)
            };

            // Arrange #1
            yield return new object[] 
            {
                new ReverseLinkedList.ListNode(1, new(2)),
                new ReverseLinkedList.ListNode(2, new(1))
            };

            // Arrange #2
            yield return new object[] 
            {
                new ReverseLinkedList.ListNode(1, new(2, new(3, new(4, new(5))))),
                new ReverseLinkedList.ListNode(5, new(4, new(3, new(2, new(1)))))
            };
        }
    }
}