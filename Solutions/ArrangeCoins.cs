// https://leetcode.com/problems/arranging-coins/

namespace Solutions
{
    public class ArrangeCoins
    {
        public int ArrangeCoinsSolution(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                n -= i;
                if (n < (i+1))
                {
                    return i;
                }
            }

            return 1;
        }        
        
        
        public int ArrangeCoinsSolution2(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            long left = 1;
            long right = n;
            long result = 1;

            while (left <= right)
            {
                long mid = left + ((right - left) / 2);

                long sum = mid * (mid + 1) / 2;
                if (sum <= n)
                {
                    result = mid;
                    left = mid + 1;
                }
                else if (sum > n)
                    right = mid - 1;
            }

            return (int)result;
        }
    }
}
