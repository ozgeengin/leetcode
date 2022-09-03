// https://leetcode.com/problems/contains-duplicate
namespace Solutions
{
    public class ContainsDuplicateProblem
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count < nums.Length;
        }
    }
}
