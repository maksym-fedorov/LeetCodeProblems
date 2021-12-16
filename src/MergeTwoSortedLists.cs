namespace LeetCode.Problems
{
    internal sealed class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    internal sealed class MergeTwoSortedLists
    {
        public static ListNode Run(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            ListNode head;
            ListNode tail;

            if (l1.val < l2.val)
            {
                head = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                head = new ListNode(l2.val);
                l2 = l2.next;
            }

            tail = head;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    tail.next = l2;

                    return head;
                }

                if (l2 == null)
                {
                    tail.next = l1;

                    return head;
                }

                if (l1.val < l2.val)
                {
                    tail.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    tail.next = new ListNode(l2.val);
                    l2 = l2.next;
                }

                tail = tail.next;
            }

            return head;
        }
    }
}