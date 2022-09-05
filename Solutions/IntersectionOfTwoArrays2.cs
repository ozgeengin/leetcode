// https://leetcode.com/problems/intersection-of-two-arrays-ii/

namespace Solutions
{
    public class IntersectionOfTwoArrays2
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dic = new Dictionary<int, int>();

            foreach(var i in nums1)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }

            var result = new List<int>();

            foreach (var i in nums2)
            {
                if (dic.ContainsKey(i) && dic[i]>0)
                {
                    dic[i]--;
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

    }
}
