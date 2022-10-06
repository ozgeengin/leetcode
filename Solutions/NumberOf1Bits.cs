// https://leetcode.com/problems/number-of-1-bits

namespace Solutions
{
    public class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            uint c = 0;

            while (n != 0)
            {
                c += n & 1; // or: c += n % 2;
                n >>= 1;    // or: n /= 2;
            }

            return (int)c;
        }

        public int HammingWeight2(uint n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }    
    }
}
