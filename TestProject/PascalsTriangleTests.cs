namespace TestProject
{
    public class PascalsTriangleTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new PascalsTriangle();

            var result = sub.Generate(5);

            result.Should().BeEquivalentTo(new List<List<int>> () {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 },
                new List<int>() { 1, 4, 6, 4, 1 },
            }, o=> o.WithStrictOrdering());
        }
    }
}
