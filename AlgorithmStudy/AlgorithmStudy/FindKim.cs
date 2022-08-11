/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12919
 */

namespace FindKim
{
    public class Solution
    {
        public string solution(string[] seoul)
        {
            int adress = 0;

            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                {
                    adress = i;
                }
            }

            return "김서방은 " + adress + "에 있다";
        }
    }
}
