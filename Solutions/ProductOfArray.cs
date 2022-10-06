// https://leetcode.com/problems/product-of-array-except-self

namespace Solutions
{
    public class ProductOfArray
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            Array.Fill(result, 1);

            var first = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] *= first;
                first *= nums[i];
            }

            int second = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= second;
                second *= nums[i];
            }

            return result;
        }
    }
}
