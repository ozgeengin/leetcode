// https://leetcode.com/problems/isomorphic-strings

namespace Solutions
{
    public class Isomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length == 1) { return true; }

            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (t[i] != dict[s[i]])
                    {
                        return false;
                    }
                }
                else
                {
                    dict.Add(s[i], t[i]);
                }
            }
            var dictVals = dict.Values.Count;
            var disValues = dict.Values.Distinct().Count();

            return dictVals == disValues;
        }
    }
}
