/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12932
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntegerToArray
{
    public class Solution
    {
        public List<int> solution(long n)
        {
            List<int> answer = new List<int>();

            while(true)
            {
                answer.Add((int)(n%10));
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
