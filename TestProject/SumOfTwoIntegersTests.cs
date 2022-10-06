namespace TestProject
{
    public class SumOfTwoIntegersTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 5;

            var sub = new SumOfTwoIntegers();

            var result = sub.GetSum(2, 3);

            result.Should().Be(expected);
        }
    }
}
