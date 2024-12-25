// https://leetcode.com/problems/permutation-in-string

using System;

namespace Solutions
{
    public class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if(s2.Length < s1.Length) return false;

            if(s2.Length == s1.Length && DoesContain(s2, s1))
            {
                return true;
            }

            for (int y = 0; y <= s2.Length-s1.Length; y++)
            {
                if (s1.Contains(s2[y]))
                {
                    var temp = s2.Substring(y, s1.Length);
                    if (DoesContain(temp,s1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool DoesContain(string s1, string s2)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in s2)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (var c in s1)
            {
                if (dict.ContainsKey(c) && dict[c] > 0)
                {
                    dict[c]--;
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
