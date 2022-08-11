/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12934
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIntegerRoot
{
    public class Solution
    {
        public long solution(long n)
        {
            double root = Math.Sqrt(n);
            if (root % 1 == 0)
            {
                return (long)((root + 1) * (root + 1));
            }

            else
            {
                return -1;
            }
        }
    }
}
