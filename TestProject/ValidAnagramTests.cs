namespace TestProject
{
    public class ValidAnagramTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new ValidAnagram();

            var result = sub.IsAnagram("anagram", "nagaram");

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var sub = new ValidAnagram();

            var result = sub.IsAnagram("rat", "car");

            result.Should().BeFalse();
        }
    }
}
