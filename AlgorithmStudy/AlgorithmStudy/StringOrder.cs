/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12917
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOrder
{
    public class Solution
    {
        public string solution(string s)
        {
            List<char> bigChar = s.Where(x => x >= 65 && x <= 95).OrderByDescending(x => x).ToList();
            List<char> smallChar = s.Where(x => x >= 97 && x <= 122).OrderByDescending(x => x).ToList();

            string answer = null;

            foreach (char c in smallChar)
            {
                answer = answer + c;
            }

            foreach (var c in bigChar)
            {
                answer = answer + c;
            }

            return answer;
        }
    }
}
