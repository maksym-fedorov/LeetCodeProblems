using LeetCode.Problems.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems.Math.AddTwoNumbers;

namespace LeetCode.Problems.Tests.Math
{
    [TestClass]
    public sealed class AddTwoNumbersTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData))]
        public void Run_ReturnsSumAsLinkedList(ListNode l1, ListNode l2, ListNode expected)
        {
            // Act
            var actual = AddTwoNumbers.Run(l1, l2);

            // Assert
            while (expected != null && actual != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }

            Assert.IsNull(expected);
            Assert.IsNull(actual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // 0 + 0 = 0
            yield return new object[]
            {
                new ListNode(0),
                new ListNode(0),
                new ListNode(0)
            };

            // 342 + 465 = 807 → [2,4,3] + [5,6,4] = [7,0,8]
            yield return new object[]
            {
                new ListNode(2, new ListNode(4, new ListNode(3))),
                new ListNode(5, new ListNode(6, new ListNode(4))),
                new ListNode(7, new ListNode(0, new ListNode(8)))
            };

            // 0 + 123 = 123 → [0] + [3,2,1] = [3,2,1]
            yield return new object[]
            {
                new ListNode(0),
                new ListNode(3, new ListNode(2, new ListNode(1))),
                new ListNode(3, new ListNode(2, new ListNode(1)))
            };

            // 99 + 1 = 100 → [9,9] + [1] = [0,0,1]
            yield return new object[]
            {
                new ListNode(9, new ListNode(9)),
                new ListNode(1),
                new ListNode(0, new ListNode(0, new ListNode(1)))
            };

            // 9 + 9 = 18 → [9] + [9] = [8,1]
            yield return new object[]
            {
                new ListNode(9),
                new ListNode(9),
                new ListNode(8, new ListNode(1))
            };

            // 9 + 9999999991 = 10000000000 → [9] + [1,9,9,9,9,9,9,9,9,9] = [0,0,0,0,0,0,0,0,0,0,1]
            yield return new object[]
            {
                new ListNode(9),
                new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9,
                    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))))))),
                new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0,
                    new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0,
                        new ListNode(1)))))))))))
            };
        }
    }
}
