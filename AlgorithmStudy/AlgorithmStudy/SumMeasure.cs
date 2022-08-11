/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12928
 */

using System;

namespace SumMeasure
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    answer = answer + i + (n / i);

                    if (i == n / i)
                    {
                        answer = answer - i;
                    }
                }
            }

            return answer;
        }
    }
}
