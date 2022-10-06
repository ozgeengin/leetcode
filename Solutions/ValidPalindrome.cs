// https://leetcode.com/problems/valid-palindrome/

namespace Solutions
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var arr = s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray();

            var start = 0;
            var end = arr.Length - 1;
            while (start < end)
            {
                if (arr[start] == arr[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
