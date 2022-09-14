namespace TestProject
{
    public class ArrangeCoinsTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 2;

            var sub = new ArrangeCoins();

            var result = sub.ArrangeCoinsSolution(5);

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 3;

            var sub = new ArrangeCoins();

            var result = sub.ArrangeCoinsSolution(8);

            result.Should().Be(expected);
        }
    }
}
