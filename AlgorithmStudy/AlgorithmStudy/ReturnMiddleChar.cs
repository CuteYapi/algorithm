/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12903
 */

namespace ReturnMiddleChar
{
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";

            if(s.Length % 2 == 0)
            {
                answer = s[(s.Length / 2) - 1].ToString() + s[s.Length / 2].ToString();
            }

            else
            {
                answer = s[s.Length / 2].ToString();
            }

            return answer;
        }
    }
}
