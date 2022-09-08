// https://leetcode.com/problems/middle-of-the-linked-list/

namespace Solutions
{
    public class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            if(head.next == null)
            {
                return head;
            }

            var list = new List<ListNode>();
            while (head.next != null)
            {
                list.Add(head);
                head = head.next;
            }
            list.Add(head);

            return list[list.Count / 2];
        }
    }

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
}
