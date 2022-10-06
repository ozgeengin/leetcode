// https://leetcode.com/problems/group-anagrams

namespace Solutions
{
    public class GroupAnagramsProblem
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            if (strs == null || strs.Length == 0)
            {
                return new List<IList<string>>();
            }

            foreach (var str in strs)
            {
                var arr = str.ToCharArray();
                Array.Sort(arr);
                var newStr = new string(arr);

                if (dict.ContainsKey(newStr))
                {
                    dict[newStr].Add(str);
                }
                else
                {
                    dict.Add(newStr, new List<string>());
                    dict[newStr].Add(str);
                }
            }

            return dict.Select(x => x.Value).ToList();
        }
    }
}
