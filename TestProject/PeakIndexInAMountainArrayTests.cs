namespace TestProject
{
    public class PeakIndexInAMountainArrayTests
    {
        [Fact]
        public void Test1()
        {
            var expected = 1;

            var sub = new PeakIndexInAMountainArray();

            var result = sub.PeakIndexInMountainArray(new int[] { 0, 1, 0 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = 1;

            var sub = new PeakIndexInAMountainArray();

            var result = sub.PeakIndexInMountainArray(new int[] { 0, 2, 1, 0 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test3()
        {
            var expected = 1;

            var sub = new PeakIndexInAMountainArray();

            var result = sub.PeakIndexInMountainArray(new int[] { 0, 10, 5, 2 });

            result.Should().Be(expected);
        }

        [Fact]
        public void Test4()
        {
            var expected = 2;

            var sub = new PeakIndexInAMountainArray();

            var result = sub.PeakIndexInMountainArray(new int[] { 3,4,5,1 });

            result.Should().Be(expected);
        }
    }
}
