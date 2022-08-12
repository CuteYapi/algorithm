/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12947
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshadNumber
{
    public class Solution
    {
        public bool solution(int x)
        {
            int sum = 0;
            int _x = x;

            while(_x > 0)
            {
                sum = sum + _x % 10;
                _x = _x / 10;
            }

            if(x % sum == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
