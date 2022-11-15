// https://leetcode.com/problems/add-two-numbers

namespace Solutions
{
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersSol(ListNode l1, ListNode l2)
        {
            var headNode = new ListNode(0);
            var currentNode = headNode;

            var x = l1;
            var y = l2;
            var carry = 0;

            while (x != null || y != null)
            {
                int a = (x != null) ? x.val : 0;
                int b = (y != null) ? y.val : 0;

                var sum = carry + a + b;
                carry = sum / 10;
                currentNode = currentNode.next = new ListNode(sum % 10);

                if (x != null) { x = x.next; }
                if (y != null) { y = y.next; }
            }

            if (carry == 1)
            { currentNode.next = new ListNode(1); }

            return headNode.next;
        }
    }
}
