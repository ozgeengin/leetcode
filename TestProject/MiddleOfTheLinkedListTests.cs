namespace TestProject
{
    public class MiddleOfTheLinkedListTests
    {
        [Fact]
        public void Test1()
        {
            var fifth = new ListNode(5);
            var fourth = new ListNode(4, fifth);
            var third = new ListNode(3, fourth);
            var second = new ListNode(2, third);
            var first = new ListNode(1, second);

            var sub = new MiddleOfTheLinkedList();

            var result = sub.MiddleNode(first);

            result.Should().Be(third);
        }

        [Fact]
        public void Test2()
        {
            var sixth = new ListNode(6);
            var fifth = new ListNode(5, sixth);
            var fourth = new ListNode(4, fifth);
            var third = new ListNode(3, fourth);
            var second = new ListNode(2, third);
            var first = new ListNode(1, second);

            var sub = new MiddleOfTheLinkedList();

            var result = sub.MiddleNode(first);

            result.Should().Be(fourth);
        }

        [Fact]
        public void Test3()
        {
            var first = new ListNode(1);

            var sub = new MiddleOfTheLinkedList();

            var result = sub.MiddleNode(first);

            result.Should().Be(first);
        }

        [Fact]
        public void Test4()
        {
            var second = new ListNode(2);
            var first = new ListNode(1, second);

            var sub = new MiddleOfTheLinkedList();

            var result = sub.MiddleNode(first);

            result.Should().Be(second);
        }

    }
}
