// https://leetcode.com/problems/search-a-2d-matrix/

namespace Solutions
{
    public class SearchA2dMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == target)
                {
                    return true;
                }

                if(!(matrix[i][0] < target && (i + 1 < matrix.Length && matrix[i+1][0] > target || i+1 >= matrix.Length)))
                {
                    continue;
                }
                
                for (int y = 0; y < matrix[i].Length; y++)
                {
                    if(matrix[i][y] == target)
                    {
                        return true;
                    } 
                }
            }

            return false;
        }
    }
}
