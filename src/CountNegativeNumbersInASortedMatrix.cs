namespace LeetCode.Problems
{
    internal sealed class CountNegativeNumbersInASortedMatrix
    {
        public static int Run(int[,] matrix)
        {
            var raws = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            
            var negatives = raws * columns;
            var raw = raws - 1;
            var column = 0;

            while (raw >= 0 && column < raws)
            {
                if (matrix[raw, column] >= 0)
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