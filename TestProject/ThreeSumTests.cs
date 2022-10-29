namespace TestProject
{
    public class ThreeSumTests
    {
        [Fact]
        public void Test1()
        {
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int> { -1, -1, 2 });
            expected.Add(new List<int> { -1, 0, 1 });

            var sub = new ThreeSumProblem();

            var result = sub.ThreeSum2(new int[] { -1, 0, 1, 2, -1, -4 });

            result.Should().BeEquivalentTo(expected);
        }
    }
}
