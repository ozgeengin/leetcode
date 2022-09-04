// https://leetcode.com/problems/rotate-array/

namespace Solutions
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            var result = (int[])nums.Clone();

            for (int i = 0; i < nums.Length; i++)
            {
                int newId = (i + k) % nums.Length;
                nums[newId] = result[i];
            }
        }
    }
}
