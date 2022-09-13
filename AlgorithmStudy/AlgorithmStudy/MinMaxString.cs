/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12939
 */

using System;

namespace MinMaxString
{
    public class Solution
    {
        public string solution(string s)
        {
            string answer;

            double min = double.PositiveInfinity;
            double max = -double.PositiveInfinity;
            string buffer = null;

            s = s + " ";

            foreach (char c in s)
            {
                if (c == ' ')
                {
                    int num = Convert.ToInt32(buffer);

                    if (num < min)
                    {
                        min = num;
                    }

                    if (num > max)
                    {
                        max = num;
                    }

                    buffer = null;
                }

                else
                {
                    buffer += c;
                }
            }

            answer = min + " " + max;
            return answer;
        }
    }
}
