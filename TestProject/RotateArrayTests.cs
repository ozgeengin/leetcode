namespace TestProject
{
    public class RotateArrayTests
    {
        [Fact]
        public void Test1()
        {
            var inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };

            var sub = new RotateArray();

            sub.Rotate(inputArray, 3);

            inputArray.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var inputArray = new int[] { -1, -100, 3, 99 };
            var expected = new int[] { 3, 99, -1, -100 };

            var sub = new RotateArray();

            sub.Rotate(inputArray, 2);

            inputArray.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
