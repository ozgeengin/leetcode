using FluentAssertions;
using Solutions;

namespace TestProject
{
    public class GuessNumberProblemTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 6;

            var sub = new GuessNumberProblem(expected);

            var result = sub.GuessNumber(10);

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 1;

            var sub = new GuessNumberProblem(expected);

            var result = sub.GuessNumber(1);

            result.Should().Be(expected);
        }

        [Fact]
        public void Test3()
        {
            var expected = 1;

            var sub = new GuessNumberProblem(expected);

            var result = sub.GuessNumber(2);

            result.Should().Be(expected);
        }

        [Fact]
        public void Test4()
        {
            var expected = 1702766719;

            var sub = new GuessNumberProblem(expected);

            var result = sub.GuessNumber(2126753390);

            result.Should().Be(expected);
        }
    }
}
