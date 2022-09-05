namespace TestProject
{
    public class ValidPerfectSquareTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new ValidPerfectSquare();

            var result = sub.IsPerfectSquare(16);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var sub = new ValidPerfectSquare();

            var result = sub.IsPerfectSquare(14);

            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var sub = new ValidPerfectSquare();

            var result = sub.IsPerfectSquare(49);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test4()
        {
            var sub = new ValidPerfectSquare();

            var result = sub.IsPerfectSquare(808201);

            result.Should().BeTrue();
        }
    }
}
