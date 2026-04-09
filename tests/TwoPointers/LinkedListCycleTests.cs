using LeetCode.Problems.TwoPointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems.TwoPointers.LinkedListCycle;

namespace LeetCode.Problems.Tests.TwoPointers
{
    [TestClass]
    public sealed class LinkedListCycleTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData))]
        public void Run_ReturnsExpectedResult(ListNode head, bool expected)
        {
            // Act
            var actual = LinkedListCycle.Run(head);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // No cycle: null list
            yield return new object[] { null!, false };

            // No cycle: single node
            yield return new object[] { new ListNode(1), false };

            // No cycle: multiple nodes
            yield return new object[]
            {
                new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) } },
                false
            };

            // Cycle: tail connects to head
            var node1 = new ListNode(3);
            var node2 = new ListNode(2) { next = new ListNode(0) { next = new ListNode(-4) { next = node1 } } };
            node1.next = node2;
            yield return new object[] { node1, true };

            // Cycle: single node cycle
            var singleCycle = new ListNode(1);
            singleCycle.next = singleCycle;
            yield return new object[] { singleCycle, true };

            // Cycle: two nodes
            var a = new ListNode(1);
            var b = new ListNode(2) { next = a };
            a.next = b;
            yield return new object[] { a, true };
        }
    }
}
