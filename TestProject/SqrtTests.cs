namespace TestProject
{
    public class SqrtTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new Sqrt();

            var result = sub.MySqrt(4);

            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var sub = new Sqrt();

            var result = sub.MySqrt(8);

            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var sub = new Sqrt();

            var result = sub.MySqrt(1);

            result.Should().Be(1);
        }

        [Fact]
        public void Test4()
        {
            var sub = new Sqrt();

            var result = sub.MySqrt(2147395599);

            result.Should().Be(46339);
        }
    }
}
