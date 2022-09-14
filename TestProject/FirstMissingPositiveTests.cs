namespace TestProject
{
    public class FirstMissingPositiveTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 3;

            var sub = new FirstMissingPositive();

            var result = sub.FirstMissingPositiveSolution(new int[] { 1, 2, 0 });

            result.Should().Be(expected);
        }        
        
        [Fact]
        public void Test2()
        {
            var expected = 2;

            var sub = new FirstMissingPositive();

            var result = sub.FirstMissingPositiveSolution(new int[] { 3, 4, -1, 1 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test3()
        {
            var expected = 1;

            var sub = new FirstMissingPositive();

            var result = sub.FirstMissingPositiveSolution(new int[] { 7, 8, 9, 11, 12 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test4()
        {
            var expected = 3;

            var sub = new FirstMissingPositive();

            var result = sub.FirstMissingPositiveSolution(new int[] { 0, 2, 2, 1, 1 });

            result.Should().Be(expected);
        }
    }
}
