namespace TestProject
{
    public class ReverseStringTests
    {
        [Fact]
        public void Test1()
        {
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = input.Reverse().ToArray();

            var sub = new ReverseStringProblem();

            sub.ReverseString(input);

            input.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            var expected = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };

            var sub = new ReverseStringProblem();

            sub.ReverseString(input);

            input.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
        }
    }
}
