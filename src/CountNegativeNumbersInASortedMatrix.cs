namespace LeetCode.Problems
{
    internal sealed class CountNegativeNumbersInASortedMatrix
    {
        public static int Run(int[][] grid)
        {
            var raws = grid.GetLength(0);
            var columns = grid[0].GetLength(0);
            
            var negatives = raws * columns;
            var raw = raws - 1;
            var column = 0;

            while (raw >= 0 && column < columns)
            {
                if (grid[raw][column] >= 0)
                {
                    negatives -= raw + 1;
                    column++;
                }
                else
                {
                    raw--;
                }
            }

            return negatives;
        }
    }
}