/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/70128
 */

namespace DotProduct
{
    public class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;

            for (int i = 0; i < a.Length; i++)
            {
                answer = answer + (a[i] * b[i]);
            }

            return answer;
        }
    }
}
