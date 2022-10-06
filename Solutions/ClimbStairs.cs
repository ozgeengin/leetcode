// https://leetcode.com/problems/climbing-stairs

namespace Solutions
{
    public class ClimbStairsProblem
    {
        public int ClimbStairs(int n)
        {
            return ClimbStairs(n, new Dictionary<int, int>());
        }

        private int ClimbStairs(int n, Dictionary<int, int> dict)
        {
            if (n < 0) return 0;

            if (n == 0) return 1;

            if(dict.ContainsKey(n))
            {
                return dict[n];
            }

            var totalCount = 0;

            for(int step = 1; step < 3; step++)
            {
                var remainder = n - step;
                if (remainder >= 0)
                {
                    var reminderResult = ClimbStairs(remainder, dict);
                    if (dict.ContainsKey(remainder))
                    {
                        dict[remainder] = reminderResult;
                    } else
                    {
                        dict.Add(remainder, reminderResult);
                    }
                    
                    totalCount += reminderResult;
                }
            }

            return totalCount;
        }
    }
}
