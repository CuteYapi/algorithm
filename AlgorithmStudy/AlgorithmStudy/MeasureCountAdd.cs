/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/77884
 */

using System;

namespace MeasureCountAdd
{
    public class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
            {
                if(Math.Sqrt(i)%1 == 0)
                {
                    answer = answer - i;
                }

                else
                {
                    answer = answer + i;
                }
            }

            return answer;
        }
    }
}
