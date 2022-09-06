// https://leetcode.com/problems/pascals-triangle/

namespace Solutions
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            List<int> prev = new List<int>();
            for (int i = 1; i <= numRows; i++)
            {
                var row = new List<int>();
                if(result.Count == 0)
                {
                    row.Add(1);
                    prev = row;
                } else if(result.Count == 1)
                {
                    row.Add(1);
                    row.Add(1);
                }
                else
                {
                    row.AddRange(GenerateCurrentRow(prev));
                }
                result.Add(row);
                prev = row;
            }

            return result;
        }

        private IEnumerable<int> GenerateCurrentRow(List<int> prev)
        {
            var result = new List<int>();
            var arr = prev.ToArray();
            result.Add(1);
            for (int i = 0; i<prev.Count-1; i++)
            {
                result.Add(arr[i] + arr[i + 1]);
            }
            result.Add(1);

            return result;
        }
    }
}
