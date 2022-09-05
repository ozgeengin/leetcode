namespace TestProject
{
    public class TwoSum2Tests
    {
        [Fact]
        public void Test1()
        {
            var expected = new int[] { 1, 2 };
            var sub = new TwoSum2();

            var result = sub.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            result.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
        }
    }
}
