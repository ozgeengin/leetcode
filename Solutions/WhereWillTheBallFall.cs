﻿// https://leetcode.com/problems/where-will-the-ball-fall

namespace Solutions
{
    public class WhereWillTheBallFall
    {
        public int[] FindBall(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            int[] result = new int[n];
            for (int i = 0; i < n; ++i)
            {
                int cy = 0;
                int cx = i;
                while (cy < m && !isBlocked(grid, cy, cx))
                {
                    cx += grid[cy][cx];
                    cy += 1;
                }

                result[i] = cy == m ? cx : -1;
            }

            return result;
        }

        private bool isBlocked(
            int[][] grid,
            int cy,
            int cx
        )
        {
            int n = grid[0].Length;
            return (grid[cy][cx] == 1 && cx == n - 1) // will hit right wall
                || (grid[cy][cx] == -1 && cx == 0)    // will hit left wall
                || (grid[cy][cx] == 1 && grid[cy][cx + 1] == -1) // V shape with next
                || (grid[cy][cx] == -1 && grid[cy][cx - 1] == 1); // V shape with previous
        }
    }
}
