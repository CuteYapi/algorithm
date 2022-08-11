/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12930
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeString
{
    public class Solution
    {
        public string solution(string s)
        {
            string answer = null;
            int i = 0;
            foreach (var c in s)
            {
                if( c == ' ')
                {
                    i = 0;
                    answer = answer + ' ';
                    continue;
                }

                if( i % 2 == 0 )
                {
                    if( 97 <= c && c <= 122 )
                    {
                        answer = answer + (char)(c - 32);
                    }

                    else
                    {
                        answer = answer + c;
                    }
                }

                else
                {
                    if( 65 <= c && c <= 90)
                    {
                        answer = answer + (char)(c + 32);
                    }

                    else
                    {
                        answer = answer + c;
                    }
                }
                i++;
            }

            return answer;
        }
    }
}
