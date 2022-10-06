/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12980
 */

namespace JumpTeleport
{
    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            while (n > 0)
            {
                if ( n % 2 == 1)
                {
                    answer++;
                }
                n /= 2;
            }

            return answer;
        }
    }
}
