namespace LeetCode.Problems
{
    public sealed class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }

            ListNode node = null;
            ListNode tail = head.next;
            head.next = node;

            while (tail != null)
            {
                node = head;
                head = tail;
                tail = head.next;
                head.next = node;
            }

            return head;
        }

        public sealed class ListNode
        {
            public int val;
            public ListNode next;
            
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}