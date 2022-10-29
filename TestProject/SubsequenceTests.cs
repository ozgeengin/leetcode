namespace TestProject
{
    public class SubsequenceTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new Subsequence();

            var result = sub.IsSubsequence("abc", "ahbgdc");

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var sub = new Subsequence();

            var result = sub.IsSubsequence("b", "abc");

            result.Should().BeTrue();
        }
    }
}
