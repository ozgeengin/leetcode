// https://leetcode.com/problems/missing-number/

namespace Solutions
{
    public class MissingNumber
    {
        public int MissingNumberSolution(int[] nums)
        {
            int xor = 0;
            int i;

            for (i = 0; i < nums.Length; i++)
            {
                xor = xor ^ i ^ nums[i];
            }

            return xor ^ i;
        }

        public int MissingNumberSolution2(int[] nums)
        {
            var n = nums.Length;
            var totalSumOfArray = n * (n + 1) / 2;

            foreach(var num in nums)
            {
                totalSumOfArray -= num;
            }

            return totalSumOfArray;
        }

        public int MissingNumberSolution3(int[] nums)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                result ^= (i + 1) ^ nums[i];
            }

            return result;
        }
    }
}
