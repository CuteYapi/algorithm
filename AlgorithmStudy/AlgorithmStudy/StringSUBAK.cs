﻿/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12922
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSUBAK
{
    public class Solution
    {
        public string solution(int n)
        {
            string answer = "";

            for (int i = 0; i < n; i++)
            {
                if(i%2 == 0)
                {
                    answer = answer + '수';
                }

                else
                {
                    answer = answer + '박';
                }
            }

            return answer;
        }
    }
}
