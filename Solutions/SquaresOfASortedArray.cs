// https://leetcode.com/problems/squares-of-a-sorted-array/

namespace Solutions
{
    public class SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            return nums.OrderBy(x => x).ToArray();
        }
    }
}
