// https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace Solutions
{
    public class MedianOfTwoSortedArraysProblem
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var combined = nums1.Concat(nums2).OrderBy(x => x).ToArray();

            int mid = combined.Length / 2;
            if (combined.Length % 2 == 0)
            {
                var first = combined[mid - 1];
                var second = combined[mid];

                return (double)(first + second) / 2;
            }

            return combined[mid];
        }
    }
}
