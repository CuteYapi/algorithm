/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12912
 */

namespace TwoSum4
{
    public class Solution
    {
        public long solution(int a, int b)
        {
            long answer = 0;

            if(a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                answer = answer + i;
            }

            return answer;
        }
    }
}
