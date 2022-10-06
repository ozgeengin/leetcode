namespace TestProject
{
    public class LastStoneWeightTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 1;

            var sub = new LastStoneWeightProblem();

            var result = sub.LastStoneWeight(new int[] {2, 7, 4, 1, 8, 1});

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 2;

            var sub = new LastStoneWeightProblem();

            var result = sub.LastStoneWeight(new int[] { 1,3 });

            result.Should().Be(expected);
        }
    }
}
