/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12937
 */

namespace OddEven
{
    public class Solution
    {
        public string solution(int num)
        {
            if(num % 2 == 0)
            {
                return "Even";
            }

            else
            {
                return "Odd";
            }
        }
    }
}
