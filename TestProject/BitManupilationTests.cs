namespace TestProject
{
    public class BitManupilationTests
    {
        [Fact]
        public void Test1()
        {
            (0 >> 1).Should().Be(0);
            (1 >> 1).Should().Be(0); //1
            (2 >> 1).Should().Be(1); //10
            (3 >> 1).Should().Be(1); //11
            (4 >> 1).Should().Be(2); //100
            (5 >> 1).Should().Be(2); //101
            (6 >> 1).Should().Be(3); //110
            (7 >> 1).Should().Be(3); //111
        }

        [Fact]
        public void Test2()
        {
            (1 & 1).Should().Be(1);
            (2 & 1).Should().Be(0);
            (3 & 1).Should().Be(1);
            (4 & 1).Should().Be(0);
            (5 & 1).Should().Be(1);
            (6 & 1).Should().Be(0);
            (7 & 1).Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            (1 ^ 1).Should().Be(0);
            (2 ^ 1).Should().Be(3);
            (3 ^ 1).Should().Be(2);
            (4 ^ 1).Should().Be(5);
            (5 ^ 1).Should().Be(4);
            (6 ^ 1).Should().Be(7);
            (7 ^ 1).Should().Be(6);
            (7^7).Should().Be(0);
            (1^3^4^5^1^2^3^4^5).Should().Be(2);
        }
    }
}
