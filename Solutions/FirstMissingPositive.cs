// https://leetcode.com/problems/first-missing-positive/

namespace Solutions
{
    public class FirstMissingPositive
    {
        public int FirstMissingPositiveSolution(int[] nums)
        {
            Array.Sort(nums);
            var index = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] == index)
                {
                    index++;
                }
            }

            return index;
        }
    }
}
