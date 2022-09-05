namespace TestProject
{
    public class IntersectionOfTwoArrays2Tests
    {
        [Fact]
        public void Test1()
        {
            var expected = new int[] { 2, 2 };

            var input1 = new int[] { 1, 2, 2, 1 };
            var input2 = new int[] { 2, 2 };
            var sub = new IntersectionOfTwoArrays2();

            var result = sub.Intersect(input1, input2);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test2()
        {
            var expected = new int[] { 4, 9 };

            var input1 = new int[] { 4, 9, 5 };
            var input2 = new int[] { 9, 4, 9, 8, 4 };
            var sub = new IntersectionOfTwoArrays2();

            var result = sub.Intersect(input1, input2);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
