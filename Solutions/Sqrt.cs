// https://leetcode.com/problems/sqrtx/

namespace Solutions
{
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            int left = 0;
            int right = x;
            while (left <= right)
            {
                var mid = (int)((long)left + right) / 2;
                var midSquare = (long)mid * mid;
                var midSquare2 = (long)(mid+1) * (mid+1);

                if(midSquare == x || (midSquare < x && midSquare2 > x))
                {
                    return mid;
                } else if(midSquare > x)
                {
                    right = mid - 1;
                } else if (midSquare < x)
                {
                    left = mid + 1;
                }
            }

            return 0;
        }
    }
}
