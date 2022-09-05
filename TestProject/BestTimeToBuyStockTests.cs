namespace TestProject
{
    public class BestTimeToBuyStockTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 5;

            var sub = new BestTimeToBuyStock();

            var result = sub.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 0;

            var sub = new BestTimeToBuyStock();

            var result = sub.MaxProfit(new int[] { 7, 6, 4, 3, 1 });

            result.Should().Be(expected);
        }
    }
}
