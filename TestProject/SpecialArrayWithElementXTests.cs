namespace TestProject
{
    public class SpecialArrayWithElementXTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 2;

            var sub = new SpecialArrayWithElementX();

            var result = sub.SpecialArray(new int[] { 3,5 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = -1;

            var sub = new SpecialArrayWithElementX();

            var result = sub.SpecialArray(new int[] { 0,0 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test3()
        {
            var expected = 3;

            var sub = new SpecialArrayWithElementX();

            var result = sub.SpecialArray(new int[] { 0, 4, 3, 0, 4 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test4()
        {
            var expected = -1;

            var sub = new SpecialArrayWithElementX();

            var result = sub.SpecialArray(new int[] { 3, 6, 7, 7, 0 });

            result.Should().Be(expected);
        }
    }
}
