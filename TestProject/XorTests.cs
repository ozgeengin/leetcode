namespace TestProject
{
    public class XorTests
    {
        [Fact]
        public void Test1()
        {
            (0 ^ 0).Should().Be(0);
            (1 ^ 1).Should().Be(0);
            (0 ^ 1).Should().Be(1);
            Convert.ToString(3, 2).Should().Be("11");
            (1^0^1).Should().Be(0);
            (3^4).Should().Be(7);
            (7^4).Should().Be(3);
            (0^1^2^4^4).Should().Be(3);
        }
    }
}
