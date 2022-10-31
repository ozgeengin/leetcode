namespace TestProject
{
    public class ToeplitzMatrixTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new ToeplitzMatrix();

            var result = sub.IsToeplitzMatrix(new int[][] {
                new int[] { 11,74,0,93 },
                new int[] { 40, 11, 74, 7 }
            });

            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var sub = new ToeplitzMatrix();

            var result = sub.IsToeplitzMatrix(new int[][] {
                new int[] { 36,59,71,15,26,82,87 },
                new int[] { 56, 36, 59, 71, 15, 26, 82},
                new int[] { 15, 0, 36, 59, 71, 15, 26}
            });

            result.Should().BeFalse();
        }
    }
}
