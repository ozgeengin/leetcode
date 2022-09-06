// https://leetcode.com/problems/reverse-string/

namespace Solutions
{
    public class ReverseStringProblem
    {
        public void ReverseString(char[] s)
        {
            var mid = s.Length / 2;

            for(int i = 0; i < mid; i++)
            {
                var secondIndex = s.Length - 1 - i;
                var temp = s[i];
                s[i] = s[secondIndex];
                s[secondIndex] = temp;
            }
        }
    }
}
