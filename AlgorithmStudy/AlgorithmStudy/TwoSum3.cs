/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/68644
 */
using System.Collections.Generic;

namespace TwoSum3
{
    public class Solution
    {
        public List<int> solution(int[] numbers)
        {
            List<int> answer = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(!answer.Contains(numbers[i] + numbers[j]))
                    {
                        answer.Add(numbers[i] + numbers[j]);
                    }
                }
            }

            answer.Sort();
            return answer;
        }
    }
}
