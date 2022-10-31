// https://leetcode.com/problems/toeplitz-matrix

namespace Solutions
{
    public class ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            for(int row=0; row < matrix.Length -1; row++)
            {
                for(int column = 0; column < matrix[row].Length-1; column++)
                {
                    if (matrix[row][column] != matrix[row + 1][column + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
