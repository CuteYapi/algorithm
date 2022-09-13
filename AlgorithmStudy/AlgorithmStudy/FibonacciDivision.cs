/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12945
 */

using System.Collections.Generic;

namespace FibonacciDivision
{
    public class Solution
    {
        public int solution(int n)
        {
            List<int> fibonacci = new List<int>();

            fibonacci.Add(0);
            fibonacci.Add(1);

            for (int i = 2; i <= n; i++)
            {
                fibonacci.Add((fibonacci[i - 1] + fibonacci[i - 2]) % 1234567);
            }

            return (fibonacci[n] % 1234567);
        }
    }
}
