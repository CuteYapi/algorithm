/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12948
 */

namespace HidePhoneNumber
{
    public class Solution
    {
        public string solution(string phone_number)
        {
            char[] answer = phone_number.ToCharArray();

            for (int i = 0; i < phone_number.Length - 4; i++)
            {
                answer[i] = '*';
            }

            string s = "";
            foreach (var item in answer)
            {
                s = s + item;
            }
            return s;
        }
    }
}
