// https://leetcode.com/problems/move-zeroes/

namespace Solutions
{
    public class MoveZeroesProblem
    {
        public void MoveZeroes(int[] nums)
        {
            var clone = (int[])nums.Clone();
            var y = 0;
            var zeroCount = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                while (y < nums.Length)
                {
                    if (clone[y] != 0)
                    {
                        nums[i] = clone[y];
                        y++;
                        break;
                    }
                     else
                    {
                        zeroCount++;
                        y++;
                    }
                }
            }

            var newIndex = nums.Length - zeroCount;
            while(newIndex < nums.Length)
            {
                nums[newIndex] = 0;
                newIndex++;
            }
        }
    }
}
