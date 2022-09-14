
namespace TestProject
{
    public class MissingNumberTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 2;

            var sub = new MissingNumber();

            var result = sub.MissingNumberSolution(new int[] { 3, 0, 1 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 2;

            var sub = new MissingNumber();

            var result = sub.MissingNumberSolution(new int[] { 0, 1 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test3()
        {
            var expected = 8;

            var sub = new MissingNumber();

            var result = sub.MissingNumberSolution(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test4()
        {
            var expected = 3;

            var sub = new MissingNumber();

            var result = sub.MissingNumberSolution(new int[] { 4, 0, 1, 2 });

            result.Should().Be(expected);
        }
    }
}
