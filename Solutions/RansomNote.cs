// https://leetcode.com/problems/ransom-note/

namespace Solutions
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineArrayDict = magazine.ToCharArray().GroupBy(c => c).ToDictionary(x => x.First(), x => x.Count());

            for(int i = 0; i < ransomNote.Length; i++)
            {
                if (!magazineArrayDict.ContainsKey(ransomNote[i]) || magazineArrayDict[ransomNote[i]] == 0)
                {
                     return false;
                }

                magazineArrayDict[ransomNote[i]]--;
            }

            return true;
        }
    }
}
