// https://leetcode.com/problems/linked-list-cycle-ii

namespace Solutions
{
    public class LinkedListCycle
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            var list = new Dictionary<ListNode, bool>();
            while (head != null)
            {
                if (list.ContainsKey(head))
                {
                    return head;
                }
                list.Add(head, true);

                head = head.next;
            }

            return null;
        }
    }
}
