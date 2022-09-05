// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

namespace Solutions
{
    public class TwoSum2
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    if (!dict.ContainsKey(target - numbers[i]))
                    {
                        dict.Add(target - numbers[i], i);
                    }
                }
                else
                {
                    return new int[] { dict[numbers[i]] + 1, i + 1 };
                }
            }

            return null;
        }
    }
}
