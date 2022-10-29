// https://leetcode.com/problems/is-subsequence

namespace Solutions
{
    public class Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (string.IsNullOrEmpty(t))
            {
                return false;
            }

            var searchArr = s.ToCharArray();
            var searchIndex = 0;
            foreach (char c in t)
            {
                if (searchArr[searchIndex] == c)
                {
                    searchIndex++;
                }

                if(searchIndex == searchArr.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
