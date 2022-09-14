namespace TestProject
{
    public class RansomNoteTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new RansomNote();

            var result = sub.CanConstruct("a", "b");

            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var sub = new RansomNote();

            var result = sub.CanConstruct("aa", "ab");

            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var sub = new RansomNote();

            var result = sub.CanConstruct("aa", "aab");

            result.Should().BeTrue();
        }
    }
}
