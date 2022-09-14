// https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/

namespace Solutions
{
    public class CountNegativeNumbers
    {
        public int CountNegatives(int[][] grid)
        {
            int count = 0;

            foreach (int[] row in grid)
            {
                for (int i = row.Length - 1; i >= 0; i--)
                {
                    if (row[i] >= 0)
                    {
                        break;
                    }

                    count++;
                }
            }

            return count;
        }
    }
}
