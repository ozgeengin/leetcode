namespace TestProject
{
    public class RemoveTheNthNodeTests
    {
        [Fact]
        public void Test1()
        {
            var fifth = new ListNode(5);
            var fourth = new ListNode(4, fifth);
            var third = new ListNode(3, fourth);
            var second = new ListNode(2, third);
            var first = new ListNode(1, second);

            var sub = new RemoveTheNthNode();

            var result = sub.RemoveNthFromEnd(first, 2);

            third.next = fifth;
            result.Should().Be(first);
        }

        [Fact]
        public void Test2()
        {
            var second = new ListNode(2);
            var first = new ListNode(1, second);

            var sub = new RemoveTheNthNode();

            var result = sub.RemoveNthFromEnd(first, 1);

            first.next = null;
            result.Should().Be(first);
        }


        [Fact]
        public void Test3()
        {
            var second = new ListNode(2);
            var first = new ListNode(1, second);

            var sub = new RemoveTheNthNode();

            var result = sub.RemoveNthFromEnd(first, 2);

            result.Should().Be(second);
        }
    }
}
