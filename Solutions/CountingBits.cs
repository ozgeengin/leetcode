// https://leetcode.com/problems/counting-bits

namespace Solutions
{
    public class CountingBits
    {
        public int[] CountBits(int n)
        {
            var result = new int[n+1];

            for(var i = 0; i <= n; i++)
            {
                var tmp = i;
                var bitCount = 0;
                while(tmp != 0)
                {
                    bitCount += tmp & 1;
                    tmp >>= 1;
                }
                result[i] = bitCount;
            }


            return result;
        }

        public int[] CountBits2(int n)
        {
            var result = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }

            return result;
        }
    }
}
