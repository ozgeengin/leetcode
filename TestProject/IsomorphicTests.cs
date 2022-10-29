namespace TestProject
{
    public class IsomorphicTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new Isomorphic();

            var result = sub.IsIsomorphic("badc", "baba");

            result.Should().BeFalse();
        }
    }
}
