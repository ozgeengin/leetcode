// https://leetcode.com/problems/first-unique-character-in-a-string/

namespace Solutions
{
    public class FirstUniqueChar
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, (bool, int)>();
            var ch = s.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                if (!dict.ContainsKey(ch[i]))
                {
                    dict.Add(ch[i], (true, i));
                }else
                {
                    dict[ch[i]] = (false, i);
                }
            }

            var hasUnique = dict.Any(kp => kp.Value.Item1);

            return hasUnique ? dict.First(kp => kp.Value.Item1).Value.Item2 : -1;
        }
    }
}
