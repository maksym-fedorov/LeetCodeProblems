using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class MergeTwoSortedListsTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Method_ReturnsMergeOfTwoSortedLists(object obj1, object obj2, object expectedObj)
        {
            var l1 = (ListNode)obj1;
            var l2 = (ListNode)obj2;
            var expectedResult = (ListNode)expectedObj;

            var actualResult = MergeTwoSortedLists.Method(l1, l2);

            while (expectedResult != null && actualResult != null)
            {
                Assert.AreEqual(actualResult.val, expectedResult.val);

                actualResult = actualResult.next;
                expectedResult = expectedResult.next;
            }

            Assert.IsNull(expectedResult);
            Assert.IsNull(actualResult);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // Arrange #0
            yield return new object[] { null, null, null };

            // Arrange #1
            var value12 = new ListNode(1);
            value12.next = new ListNode(3);
            value12.next.next = new ListNode(4);
            yield return new object[] { null, value12, value12 };

            // Arrange #2
            var value21 = new ListNode(1);
            value21.next = new ListNode(2);
            yield return new object[] { value21, null, value21 };

            // Arrange #3
            var value31 = new ListNode(1);
            value31.next = new ListNode(2);

            var value32 = new ListNode(1);
            value32.next = new ListNode(2);
            value32.next.next = new ListNode(3);
            value32.next.next.next = new ListNode(4);

            var expected32 = new ListNode(1);
            expected32.next = new ListNode(1);
            expected32.next.next = new ListNode(2);
            expected32.next.next.next = new ListNode(2);
            expected32.next.next.next.next = new ListNode(3);
            expected32.next.next.next.next.next = new ListNode(4);

            yield return new object[] { value31, value32, expected32 };
        }
    }
}