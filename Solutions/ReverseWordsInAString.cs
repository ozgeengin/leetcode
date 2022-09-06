// https://leetcode.com/problems/reverse-words-in-a-string-iii/

using System.Text;

namespace Solutions
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            var wordArray = s.Split(' ');
            var sb = new StringBuilder();
            for (var i = 0; i < wordArray.Length; i++)
            {
                sb.Append(ReverseString(wordArray[i]));
                if(i < wordArray.Length - 1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }

        private string ReverseString(string str)
        {
            var s = str.ToCharArray();
            var mid = s.Length / 2;

            for (int i = 0; i < mid; i++)
            {
                var secondIndex = s.Length - 1 - i;
                var temp = s[i];
                s[i] = s[secondIndex];
                s[secondIndex] = temp;
            }

            return new string(s);
        }
    }
}
