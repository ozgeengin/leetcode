// https://leetcode.com/problems/sum-of-two-integers

namespace Solutions
{
    public class SumOfTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                var c = a & b;
                a ^= b;
                b = c << 1;
            }

            return a;
        }
    }
}
