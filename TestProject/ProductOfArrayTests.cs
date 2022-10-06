namespace TestProject
{
    public class ProductOfArrayTests
    {
        [Fact]
        public void Test1()
        {
            var expected = new int[] {24,12,8,6};

            var sub = new ProductOfArray();

            var result = sub.ProductExceptSelf(new int[] { 1,2,3,4 });

            result.Should().BeEquivalentTo(expected);
        }
    }
}
