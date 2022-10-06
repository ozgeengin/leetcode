// https://leetcode.com/problems/top-k-frequent-elements

namespace Solutions
{
    public class TopKFrequentNumbers
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var query = nums.GroupBy(x => x).Select(x => new { x.Key, count = x.Count() }).OrderByDescending(x => x.count).Take(k).Select(x => x.Key).ToArray();

            return query;
        }
    }
}
