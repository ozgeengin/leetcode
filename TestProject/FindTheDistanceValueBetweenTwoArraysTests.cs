namespace TestProject
{
    public class FindTheDistanceValueBetweenTwoArraysTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new FindTheDistanceValueBetweenTwoArrays();

            var result = sub.FindTheDistanceValue(new int[]{ 4,5,8}, new int[] {10,9,1,8}, 2);

            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var sub = new FindTheDistanceValueBetweenTwoArrays();

            var result = sub.FindTheDistanceValue(new int[] { 1, 4, 2, 3 }, new int[] { -4, -3, 6, 10, 20, 30 }, 3);

            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var sub = new FindTheDistanceValueBetweenTwoArrays();

            var result = sub.FindTheDistanceValue(new int[] { 2, 1, 100, 3 }, new int[] { -5, -2, 10, -3, 7 }, 6);

            result.Should().Be(1);
        }
    }
}
