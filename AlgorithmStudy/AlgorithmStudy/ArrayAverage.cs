/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12944
 */

namespace ArrayAverage
{
    public class Solution
    {
        public double solution(int[] arr)
        {
            double answer = 0;

            foreach (var item in arr)
            {
                answer = answer + item;
            }

            return answer / arr.Length;
        }
    }
}
