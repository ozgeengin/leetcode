namespace TestProject
{
    public class MoveZeroesTests
    {
        [Fact]
        public void Test1()
        {
            var expected = new int[] { 1, 3, 12, 0, 0 };
            var input = new int[] { 0, 1, 0, 3, 12 };
            var sub = new MoveZeroesProblem();

            sub.MoveZeroes(input);

            input.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var expected = new int[] { 0 };
            var input = new int[] { 0 };
            var sub = new MoveZeroesProblem();

            sub.MoveZeroes(input);

            input.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test3()
        {
            var expected = new int[] { -58305, -22022, -76070, 42820, 48119, 95708, -91393, 60044, -34562, -88974, 0, 0, 0, 0, 0, 0, 0, 0 };
            var input = new int[] { -58305, -22022, 0, 0, 0, 0, 0, -76070, 42820, 48119, 0, 95708, -91393, 60044, 0, -34562, 0, -88974 };
            var sub = new MoveZeroesProblem();

            sub.MoveZeroes(input);

            input.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
