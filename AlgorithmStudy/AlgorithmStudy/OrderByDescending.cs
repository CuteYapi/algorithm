/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12933
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByDescending
{
    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;
            List<int> answerInt = new List<int>();

            while (n > 0)
            {
                answerInt.Add((int)(n % 10));
                n /= 10;
            }

            answerInt.Sort();
            answerInt.Reverse();

            foreach (var item in answerInt)
            {
                answer = (answer * 10) + item;
            }

            return answer;
        }
    }
}
