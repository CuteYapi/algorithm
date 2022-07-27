/* https://school.programmers.co.kr/learn/courses/30/lessons/76501
 * 
 * */

namespace PlusMinus
{
    public class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 123456789;
            answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i])
                {
                    answer = answer + absolutes[i];
                }

                else
                {
                    answer = answer - absolutes[i];
                }
            }
            return answer;
        }
    }
}
