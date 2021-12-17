using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Problems.Tests
{
    [TestClass]
    public sealed class MergeTwoBinaryTreesTests
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Run_ReturnsMergeOfTwoSortedLists(object obj1, object obj2, object expectedObj)
        {
            var root1 = (MergeTwoBinaryTrees.TreeNode)obj1;
            var root2 = (MergeTwoBinaryTrees.TreeNode)obj2;
            var expected = (MergeTwoBinaryTrees.TreeNode)expectedObj;

            // Act
            var actual = MergeTwoBinaryTrees.Run(root1, root2);

            // Assert
            var expectedNodesQueue = new Queue<MergeTwoBinaryTrees.TreeNode>();
            var actualNodesQueue = new Queue<MergeTwoBinaryTrees.TreeNode>();
            expectedNodesQueue.Enqueue(expected);
            actualNodesQueue.Enqueue(actual);
            
            while (!expectedNodesQueue.TryDequeue(out var expectedNode) && !actualNodesQueue.TryDequeue(out var actualNode))
            {
                if (expectedNode == null || actualNode == null)
                {
                    Assert.IsNull(expected);
                    Assert.IsNull(actual);

                    continue;
                }

                Assert.Equals(expectedNode.val, actualNode.val);

                expectedNodesQueue.Enqueue(expectedNode.left);
                expectedNodesQueue.Enqueue(expectedNode.right);
                actualNodesQueue.Enqueue(expectedNode.left);
                actualNodesQueue.Enqueue(expectedNode.right);
            }
        }

        private static IEnumerable<object[]> GetTestData()
        {
            // Arrange #0
            var root01 = new MergeTwoBinaryTrees.TreeNode(1);
            var root02 = new MergeTwoBinaryTrees.TreeNode(1);
            root02.left = new MergeTwoBinaryTrees.TreeNode(2);
            var expected0 = new MergeTwoBinaryTrees.TreeNode(2);
            expected0.left = new MergeTwoBinaryTrees.TreeNode(2);
            yield return new object[] { root01, root02, expected0 };

            // Arrange #1
            var root11 = new MergeTwoBinaryTrees.TreeNode(1);
            root11.left = new MergeTwoBinaryTrees.TreeNode(3);
            root11.right = new MergeTwoBinaryTrees.TreeNode(2);
            root11.left.left = new MergeTwoBinaryTrees.TreeNode(5);

            var root12 = new MergeTwoBinaryTrees.TreeNode(2);
            root12.left = new MergeTwoBinaryTrees.TreeNode(1);
            root12.right = new MergeTwoBinaryTrees.TreeNode(3);
            root12.left.right = new MergeTwoBinaryTrees.TreeNode(4);
            root12.right.right = new MergeTwoBinaryTrees.TreeNode(7);

            var expected1 = new MergeTwoBinaryTrees.TreeNode(3);
            expected1.left = new MergeTwoBinaryTrees.TreeNode(4);
            expected1.right = new MergeTwoBinaryTrees.TreeNode(5);
            expected1.left.left = new MergeTwoBinaryTrees.TreeNode(5);
            expected1.left.right = new MergeTwoBinaryTrees.TreeNode(4);
            expected1.right.right = new MergeTwoBinaryTrees.TreeNode(7);

            yield return new object[] { root11, root12, expected1 };
        }
    }
}