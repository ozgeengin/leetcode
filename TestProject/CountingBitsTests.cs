
namespace TestProject
{
    public class CountingBitsTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new CountingBits();

            var result = sub.CountBits2(5);

            result.Should().BeEquivalentTo(new int[] { 0, 1, 1, 2, 1, 2 } , options => options.WithStrictOrdering());
        }
    }
}
