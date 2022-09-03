// https://leetcode.com/problems/binary-search

namespace Solutions
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            var leftIndex = 0;
            var rightIndex = nums.Length - 1;
            
            while(rightIndex >= leftIndex)
            {
                int midIndex = (rightIndex + leftIndex) / 2;
                if(nums[midIndex] == target)
                {
                    return midIndex;
                }else if(nums[midIndex] < target)
                {
                    leftIndex = midIndex + 1;
                } else
                {
                    rightIndex = midIndex - 1;
                }
            }

            return -1;
        }
    }
}
