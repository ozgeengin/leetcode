// https://leetcode.com/problems/reverse-linked-list

namespace Solutions
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev;
            ListNode next = null;
            while (head != null)
            {
                prev = next;
                next = head;
                head = head.next;
                next.next = prev;
            }

            return next;
        }
    }
}
