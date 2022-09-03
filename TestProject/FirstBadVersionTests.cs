using FluentAssertions;
using Solutions;

namespace TestProject
{
    public class FirstBadVersionTests
    {
        [Fact]
        public void Test1()
        {
            var firstBadVersion = 1150769282;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(1420736637);

            result.Should().Be(firstBadVersion);
        }

        [Fact]
        public void Test2()
        {
            var firstBadVersion = 1702766719;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(2126753390);

            result.Should().Be(firstBadVersion);
        }

        [Fact]
        public void Test3()
        {
            var firstBadVersion = 2;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(2);

            result.Should().Be(firstBadVersion);
        }

        [Fact]
        public void Test4()
        {
            var firstBadVersion = 1;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(2);

            result.Should().Be(firstBadVersion);
        }

        [Fact]
        public void Test5()
        {
            var firstBadVersion = 1;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(1);

            result.Should().Be(firstBadVersion);
        }

        [Fact]
        public void Test6()
        {
            var firstBadVersion = 4;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(5);

            result.Should().Be(firstBadVersion);
        }

        [Fact]
        public void Test7()
        {
            var firstBadVersion = 1;

            var sub = new FirstBadVersionProblem(firstBadVersion);

            var result = sub.FirstBadVersion(3);

            result.Should().Be(firstBadVersion);
        }
    }
}