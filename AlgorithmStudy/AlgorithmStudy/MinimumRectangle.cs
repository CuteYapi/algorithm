/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/86491
 */

namespace MinimumRectangle
{
    public class Solution
    {
        public int solution(int[,] sizes)
        {
            int answer = 0;
            int temp = 0;
            int horizontal = 0;
            int vertical = 0;

            for (int i = 0; i < sizes.Length / 2; i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }

                if (sizes[i, 0] > horizontal)
                {
                    horizontal = sizes[i, 0];
                }

                if (sizes[i, 1] > vertical)
                {
                    vertical = sizes[i, 1];
                }
            }

            answer = horizontal * vertical;
            return answer;
        }
    }
}
