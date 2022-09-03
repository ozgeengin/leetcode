using FluentAssertions;
using Solutions;

namespace TestProject
{
    public class SearchInsertPositionTests
    {
        [Fact]
        public void Test1()
        {
            var sub = new SearchInsertPosition();

            var result = sub.SearchInsert(new int[] {1,3,5,6}, 5);

            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var sub = new SearchInsertPosition();

            var result = sub.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);

            result.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var sub = new SearchInsertPosition();

            var result = sub.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);

            result.Should().Be(4);
        }

    }
}
