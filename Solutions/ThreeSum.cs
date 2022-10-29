// https://leetcode.com/problems/3sum

namespace Solutions
{
    public class ThreeSumProblem
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums.Length == 3 && nums[0] + nums[1] + nums[2] != 0)
            {
                return result;
            }

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int x = i + 1; x < nums.Length - 1; x++)
                {
                    for (int y = x + 1; y < nums.Length; y++)
                    {
                        var first = nums[i];
                        var second = nums[x];
                        var third = nums[y];
                        if (first + second + third == 0)
                        {
                            var doesExist = result.Any(x => x.Contains(first) && x.Contains(second) && x.Contains(third));
                            if (!doesExist)
                            {
                                result.Add(new List<int> { first, second, third });
                            }
                        }
                    }
                }
            }

            return result.Distinct().ToList();
        }

        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums.Length == 3 && nums[0] + nums[1] + nums[2] != 0)
            {
                return result;
            }

            var index1 = 0;
            var index2 = index1 + 1;
            var index3 = nums.Length - 1;

            while (index2 < nums.Length)
            {
                var first = nums[index1];
                var second = nums[index2];
                var third = nums[index3];
                if (first + second + third == 0)
                {
                    result.Add(new List<int> { first, second, third });
                }

                if (index2 +1< index3)
                {
                    index1++;
                    index3--;
                    index2 = index1 + 1;
                }
            }
            return result.Distinct().ToList();
        }
    }
}
