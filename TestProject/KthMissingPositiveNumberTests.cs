namespace TestProject
{
    public class KthMissingPositiveNumberTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 9;

            var sub = new KthMissingPositiveNumber();

            var result = sub.FindKthPositive(new int[] { 2, 3, 4, 7, 11 }, 5);

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 6;

            var sub = new KthMissingPositiveNumber();

            var result = sub.FindKthPositive(new int[] { 1, 2, 3, 4 }, 2);

            result.Should().Be(expected);
        }
    }
}
