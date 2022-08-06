/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12910
 */

using System.Collections.Generic;

namespace DivisorArray
{
    public class Solution
    {
        public List<int> solution(int[] arr, int divisor)
        {
            List<int> answer = new List<int>();

            foreach (var item in arr)
            {
                if(item % divisor == 0)
                {
                    answer.Add(item);
                }
            }
            answer.Sort();

            if (answer.Count != 0)
            {
                return answer;
            }

            else
            {
                answer.Add(-1);
                return answer;
            }
        }
    }
}
