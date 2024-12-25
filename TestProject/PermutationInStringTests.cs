namespace TestProject
{
    public class PermutationInStringTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new PermutationInString();

            var result = sub.CheckInclusion("ab", "eidbaooo");

            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var sub = new PermutationInString();

            var result = sub.CheckInclusion("ab", "eidboaoo");

            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var sub = new PermutationInString();

            var result = sub.CheckInclusion("adc", "dcda");

            result.Should().BeTrue();
        }

        [Fact]
        public void Test4()
        {
            var sub = new PermutationInString();

            var result = sub.CheckInclusion("ab", "ab");

            result.Should().BeTrue();
        }

        [Fact]
        public void Test5()
        {
            var sub = new PermutationInString();

            var result = sub.CheckInclusion("hello", "ooolleoooleh");

            result.Should().BeFalse();
        }

        [Fact]
        public void Test6()
        {
            var sub = new PermutationInString();

            var result = sub.CheckInclusion("a", "b");

            result.Should().BeFalse();
        }
    }
}
