namespace LeetCode.Problems.TwoPointers
{
    public class ContainerWithMostWater
    {
        public static int Run(int[] heights)
        {
            int h1 = 0, h2 = heights.Length - 1;
            int maxArea = 0;

            while (h1 < h2)
            {
                int area = System.Math.Min(heights[h1], heights[h2]) * (h2 - h1);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (heights[h1] < heights[h2])
                {
                    h1++;
                }
                else
                {
                    h2--;
                }
            }

            return maxArea;
        }
    }
}
