namespace TestProject
{
    public class LongestSequenceTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new LongestSequence();

            var result = sub.LongestConsecutive(new int[] { 100, 1, 3, 4, 300, 2 });

            result.Should().Be(4);
        }        
        
        [Fact]
        public void Test2()
        {
            var sub = new LongestSequence();

            var result = sub.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });

            result.Should().Be(9);
        }
    }
}
