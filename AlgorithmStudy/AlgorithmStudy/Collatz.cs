/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12943
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz
{
    public class Solution
    {
        public int solution(int num)
        {
            if (num == 1)
            {
                return 0;
            }

            for (int i = 1; i <= 500; i++)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }

                else if (num % 2 == 1)
                {
                    num = num * 3 + 1;
                }

                if ( num == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
