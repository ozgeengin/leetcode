namespace TestProject
{
    public class SearchA2dMatrixTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new SearchA2dMatrix();

            var result = sub.SearchMatrix(new int[][] {
                new int[]{1,3,5,7},
                new int[]{10,11,16,20},
                new int[]{23,30,34,60}}, 3);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var sub = new SearchA2dMatrix();

            var result = sub.SearchMatrix(new int[][] {
                new int[]{1,1}}, 0);

            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var sub = new SearchA2dMatrix();

            var result = sub.SearchMatrix(new int[][] {
                new int[]{1,3}}, 3);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test4()
        {
            var sub = new SearchA2dMatrix();

            var result = sub.SearchMatrix(new int[][] {
                new int[]{1}, new int[]{3}}, 2);

            result.Should().BeFalse();
        }

        [Fact]
        public void Test5()
        {
            var sub = new SearchA2dMatrix();

            var result = sub.SearchMatrix(new int[][] {
                new int[]{1,3,5,7 },
                new int[]{10, 11, 16, 20 },
                new int[]{23, 30, 34, 60 } }, 13);

            result.Should().BeFalse();
        }
    }
}
