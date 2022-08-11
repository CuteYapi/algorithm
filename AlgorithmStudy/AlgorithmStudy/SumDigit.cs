/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12931
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            while (true)
            {
                answer = answer + n % 10;
                n = n / 10;
                if(n == 0)
                {
                    break;
                }
            }

            return answer;
        }
    }
}
