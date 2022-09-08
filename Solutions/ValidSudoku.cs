// https://leetcode.com/problems/valid-sudoku/

namespace Solutions
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = new Dictionary<int, List<char>>();
            var columns = new Dictionary<int, List<char>>();
            var squares = new Dictionary<int, List<char>>();
            for(int i = 0; i < 9; i++)
            {
                for(int y = 0; y <9; y++)
                {
                    var current = board[i][y];
                    
                    if (current == '.')
                    {
                        continue;
                    }

                    var squareKey = i / 3 * 3 + y / 3;
                    if (!IsUnique(squares, squareKey, current) ||
                        !IsUnique(rows, i, current) ||
                        !IsUnique(columns, y, current))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsUnique(Dictionary<int, List<char>> dic, int key, char c)
        {
            if (dic.ContainsKey(key) && dic[key].Contains(c))
            {
                return false;
            }

            if (!dic.ContainsKey(key))
            {
                dic.Add(key, new List<char>());
            }
            
            dic[key].Add(c);

            return true;
        }
    }
}
