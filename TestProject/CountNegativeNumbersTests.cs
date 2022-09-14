namespace TestProject
{
    public class CountNegativeNumbersTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 8;

            var sub = new CountNegativeNumbers();

            var result = sub.CountNegatives(new int[][] {
                new int[] { 4, 3, 2, -1 },
                new int[] { 3, 2, 1, -1 },
                new int[] { 1, 1, -1, -2 },
                new int[] { -1, -1, -2, -3 }
            });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 0;

            var sub = new CountNegativeNumbers();

            var result = sub.CountNegatives(new int[][] {
                new int[] { 3, 2 },
                new int[] { 1, 0 }
            });

            result.Should().Be(expected);
        }
    }
}
