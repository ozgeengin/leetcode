// https://leetcode.com/problems/first-bad-version

using System.Security.Cryptography;

namespace Solutions
{
    public class FirstBadVersionProblem
    {
        private readonly int BadVersion;

        public FirstBadVersionProblem(int badVersion)
        {
            BadVersion = badVersion;
        }

        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;
            if (right == 1 && IsBadVersion(1))
            {
                return 1;
            }

            if (IsBadVersion(left))
            {
                return left;
            }

            if (!IsBadVersion(right))
            {
                return -1;
            }

            while (right >= left)
            {
                long sum = right + (long)left;
                int mid = (int)(sum / 2);
                var isBad = IsBadVersion(mid);

                if (isBad && (right == left || left +1 == right))
                {
                    return mid;
                }
                
                if (!isBad && right == left)
                {
                    return mid + 1;
                }

                if (!isBad)
                {
                    left = mid + 1;
                }
                else if (isBad)
                {
                    right = mid - 1;
                }
            }

            return -1;

        }

        private bool IsBadVersion(int n)
        {
            return n >= BadVersion;
        }
    }
}
