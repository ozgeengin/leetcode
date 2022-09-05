namespace TestProject
{
    public class StringToIntegerTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("42");

            result.Should().Be(42);
        }

        [Fact]
        public void Test2()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("   -42");

            result.Should().Be(-42);
        }

        [Fact]
        public void Test3()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("4193 with words");

            result.Should().Be(4193);
        }

        [Fact]
        public void Test4()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("words and 987");

            result.Should().Be(0);
        }

        [Fact]
        public void Test5()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("0032");

            result.Should().Be(32);
        }

        [Fact]
        public void Test6()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("-91283472332");

            result.Should().Be(-2147483648);
        }

        [Fact]
        public void Test7()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("+-12");

            result.Should().Be(0);
        }

        [Fact]
        public void Test8()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi("00000-42a1234");

            result.Should().Be(0);
        }

        [Fact]
        public void Test9()
        {
            var sub = new StringToInteger();

            var result = sub.MyAtoi(" ");

            result.Should().Be(0);
        }
    }
}
