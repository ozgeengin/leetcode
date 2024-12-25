// https://leetcode.com/problems/contains-duplicate

namespace Solutions
{
    public class ContainsDuplicateProblem
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count < nums.Length;
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public bool ContainsDuplicate2(int[] nums)
        {
            var existingNums = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!existingNums.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
