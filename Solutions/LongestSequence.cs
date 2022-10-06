// https://leetcode.com/problems/longest-consecutive-sequence

namespace Solutions
{
    public class LongestSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            if (nums.Length == 1) return 1;

            Array.Sort(nums);

            int result = 1;
            int temp = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) continue;

                if (nums[i] == nums[i - 1] + 1)
                {
                    temp++;
                    result = Math.Max(temp, result);
                }
                else
                {
                    temp = 1;
                }
            }

            return result;
        }
    }
}
