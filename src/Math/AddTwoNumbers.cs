using static System.Net.Mime.MediaTypeNames;

namespace LeetCode.Problems.Math
{
    public sealed class AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode Run(ListNode l1, ListNode l2)
        {
            ListNode s = new ListNode(0);
            var head = s;

            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    s.val += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    s.val += l2.val;
                    l2 = l2.next;
                }

                if (s.val >= 10)
                {
                    s.val -= 10;
                    s.next = new ListNode(1);
                }
                else if (l1 != null || l2 != null)
                {
                    s.next = new ListNode(0);
                }
                s = s.next;
            }

            return head;
        }
    }
}
