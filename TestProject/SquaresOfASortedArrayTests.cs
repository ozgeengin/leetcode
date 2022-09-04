namespace TestProject
{
    public class SquaresOfASortedArrayTests
    {
        [Fact]
        public void Test1()
        {
            var expected = new int[] { 0, 1, 9, 16, 100 };

            var sub = new SquaresOfASortedArray();

            var result = sub.SortedSquares(new int[] { -4, -1, 0, 3, 10 });

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = new int[] { 4, 9, 9, 49, 121 };

            var sub = new SquaresOfASortedArray();

            var result = sub.SortedSquares(new int[] { -7, -3, 2, 3, 11 });

            result.Should().BeEquivalentTo(expected);
        }
    }
}
