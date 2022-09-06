namespace TestProject
{
    public class FindSmallestLetterTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new FindSmallestLetter();

            var result = sub.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'a');

            result.Should().Be('c');
        }

        [Fact]
        public void Test2()
        {
            var sub = new FindSmallestLetter();

            var result = sub.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'c');

            result.Should().Be('f');
        }

        [Fact]
        public void Test3()
        {
            var sub = new FindSmallestLetter();

            var result = sub.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'd');

            result.Should().Be('f');
        }

        [Fact]
        public void Test4()
        {
            var sub = new FindSmallestLetter();

            var result = sub.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'j');

            result.Should().Be('c');
        }
    }
}
