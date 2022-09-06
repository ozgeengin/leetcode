// https://leetcode.com/problems/reshape-the-matrix/

namespace Solutions
{
    public class ReshapeTheMatrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var matFieldCount = mat.Length * mat[0].Length;

            var newFieldCount = r * c;
            var newArray = new int[r][];

            if(matFieldCount == newFieldCount)
            {
                var newFlatArray = GetFlatArray(mat);
                var index = 0;
                for (int i = 0; i < r; i++)
                {
                    newArray[i] = new int[c];
                    for (int y = 0; y < c; y++)
                    {
                        newArray[i][y] = newFlatArray[index];
                        index++;
                    }
                }

                return newArray;
            }

            return mat;
        }

        private int[] GetFlatArray(int[][] arr)
        {
            var newArr = new List<int>();
            foreach(var a in arr)
            {
                foreach(var b in a)
                {
                    newArr.Add(b);
                }
            }

            return newArr.ToArray();
        }
    }
}
