// https://leetcode.com/problems/kth-missing-positive-number/

namespace Solutions
{
    public class KthMissingPositiveNumber
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int left = 0, right = arr.Length, mid;

            while (left < right)
            {
                mid = (left + right) / 2;
                if (arr[mid] - 1 - mid < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left + k;
        }
    }
}
