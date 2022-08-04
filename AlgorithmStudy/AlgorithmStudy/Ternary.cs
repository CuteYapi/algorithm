/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/68935
 */
using System.Collections.Generic;

namespace Ternary
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            List<int> ternarySet = new List<int>();

            while (n > 0)
            {
                ternarySet.Add(n%3);
                n = n / 3;
            }

            for (int i = 0; i < ternarySet.Count; i++)
            {
                answer = answer * 3 + ternarySet[i];
            }

            return answer;
        }
    }
}
