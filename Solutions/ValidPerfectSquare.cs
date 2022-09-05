// https://leetcode.com/problems/valid-perfect-square/

namespace Solutions
{
    public class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1)
            {
                return true;
            }

            long left = 0, right = num;
            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                long val = mid * mid;

                if (num == val)
                {
                    return true;
                } 
                else if (num > val)
                {
                    left = mid +1;
                }
                else
                {
                    right = mid -1;
                }
            }

            return false;
        }
    }
}
