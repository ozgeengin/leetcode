namespace TestProject
{
    public class ReshapeTheMatrixTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new ReshapeTheMatrix();

            var result = sub.MatrixReshape(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }, 1, 4);

            result.Should().BeEquivalentTo(new int[][] { new int[] { 1, 2, 3, 4 } });
        }

        [Fact]
        public void Test2()
        {
            var input = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            var sub = new ReshapeTheMatrix();

            var result = sub.MatrixReshape(input, 2, 4);

            result.Should().BeEquivalentTo(input , o => o.WithStrictOrdering());
        }
    }
}
