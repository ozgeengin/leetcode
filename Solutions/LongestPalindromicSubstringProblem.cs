// https://leetcode.com/problems/longest-palindromic-substring/

namespace Solutions
{
    public class LongestPalindromicSubstringProblem
    {
        public string LongestPalindrome(string s)
        {

            char[] stringChar = s.ToCharArray();
            int fullStringLentgh = s.Length;
            int maxLength = 0;
            int minLeft = 0;
            string result = "";
            for (int i = 0; i < fullStringLentgh; i++)
            {
                int left;
                int right;

                int times = 2;

                while (times != 0)
                {

                    if (times == 2)
                    {
                        left = i;
                        right = i + 1;

                    }
                    else
                    {
                        left = i;
                        right = i;
                    }
                    while (left >= 0 && right < fullStringLentgh && stringChar[left] == stringChar[right])
                    {

                        if (right - left + 1 > maxLength)
                        {
                            maxLength = right - left + 1;
                            minLeft = left;
                        }
                        right++;
                        left--;

                    }

                    --times;
                }

            }

            result = s.Substring(minLeft, maxLength);
            return result;
        }
    }
}
