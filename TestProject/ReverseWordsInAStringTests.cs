namespace TestProject
{
    public class ReverseWordsInAStringTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new ReverseWordsInAString();

            var result = sub.ReverseWords("Let's take LeetCode contest");

            result.Should().Be("s'teL ekat edoCteeL tsetnoc");
        }

        [Fact]
        public void Test2()
        {
            var sub = new ReverseWordsInAString();

            var result = sub.ReverseWords("God Ding");

            result.Should().Be("doG gniD");
        }
    }
}
