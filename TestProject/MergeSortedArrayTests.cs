namespace TestProject
{
    public class MergeSortedArrayTests
    {
        [Fact]
        public void Test1()
        {
            var expected = new int[] { 1, 2, 2, 3, 5, 6 };
            var intput = new int[] { 1, 2, 3, 0, 0, 0 };
            var sub = new MergeSortedArray();

            sub.Merge(intput, 3, new int[] { 2, 5, 6 }, 3);

            intput.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var expected = new int[] { 1 };
            var intput = new int[] { 0 };
            var sub = new MergeSortedArray();

            sub.Merge(intput, 0, new int[] { 1 }, 1);

            intput.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
