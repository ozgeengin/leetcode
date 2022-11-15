namespace TestProject
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void Test1()
        {
            var param1 = new ListNode(1);
            param1.next = new ListNode(9);
            param1.next.next = new ListNode(9);
            param1.next.next.next = new ListNode(9);
            param1.next.next.next.next = new ListNode(9);
            param1.next.next.next.next.next = new ListNode(9);
            param1.next.next.next.next.next.next = new ListNode(9);
            param1.next.next.next.next.next.next.next = new ListNode(9);
            param1.next.next.next.next.next.next.next.next = new ListNode(9);
            param1.next.next.next.next.next.next.next.next.next = new ListNode(9);

            var sub = new AddTwoNumbers();

            var result = sub.AddTwoNumbersSol(new ListNode(9), param1);

            result.val.Should().Be(0);
            result.next.val.Should().Be(0);
            result.next.next.val.Should().Be(0);
            result.next.next.next.val.Should().Be(0);
            result.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.next.next.val.Should().Be(1);
        }
    }
}
