// https://leetcode.com/problems/merge-two-sorted-lists

namespace Solutions
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var root = new ListNode();
            var prev = root;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }
            prev.next = list1 ?? list2;

            return root.next;
        }
    }
}
