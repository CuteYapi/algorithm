/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12954
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSumX
{
    public class Solution
    {
        public long[] solution(int x, int n)
        {
            List<long> answer = new List<long>();
            long _x = x;

            for (int i = 0; i < n; i++)
            {
                answer.Add(_x);
                _x = _x + x;
            }

            return answer.ToArray();
        }
    }
}
