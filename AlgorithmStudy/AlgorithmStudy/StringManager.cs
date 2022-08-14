/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12918
 */

namespace StringManager
{
    public class Solution
    {
        public bool solution(string s)
        {
            if(!(s.Length == 4 || s.Length == 6))
            {
                return false;
            }

            foreach (var c in s)
            {
                if(!(48 <= c && c <= 57))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
