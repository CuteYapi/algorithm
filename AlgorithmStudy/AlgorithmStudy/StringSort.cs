/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12915
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSort
{
    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };

            Array.Sort(strings);
            answer = strings.OrderBy(x => x[n]).ToArray();

            return answer;
        }
    }
}
