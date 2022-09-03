// https://leetcode.com/problems/maximum-subarray/

namespace Solutions
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var currentSum = 0;
            var sum = int.MinValue;

            foreach (var num in nums)
            {
                currentSum += num;
                if (currentSum < num)
                {
                    currentSum = num;
                }

                sum = Math.Max(sum, currentSum);
            }

            return sum;
        }
    }
}
