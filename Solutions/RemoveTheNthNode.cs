// https://leetcode.com/problems/remove-nth-node-from-end-of-list/

namespace Solutions
{
    public class RemoveTheNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null && n == 1)
            {
                return null;
            }

            var list = new List<ListNode>();
            while (head.next != null)
            {
                list.Add(head);
                head = head.next;
            }
            list.Add(head);

            if (list.Count == list.Count - n + 1)
            {
                list[list.Count - n - 1].next = null;
            }
            else if (list.Count == n)
            {
                return list[list.Count - n + 1];
            }
            else
            {
                list[list.Count - n - 1].next = list[list.Count - n + 1];
            }


            return list[0];
        }
    }
}
