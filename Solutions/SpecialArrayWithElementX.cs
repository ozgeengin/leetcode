// https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/

namespace Solutions
{
    public class SpecialArrayWithElementX
    {
        public int SpecialArray(int[] nums)
        {
            int left = 1, right = nums.Max();

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int count = nums.Count(x => x >= mid);

                if (count == mid)
                {
                    return mid;
                }

                if (count > mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
