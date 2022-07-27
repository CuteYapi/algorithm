/* https://school.programmers.co.kr/learn/courses/30/lessons/86051
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyNumberSum
{
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 45;

            foreach (var num in numbers)
            {
                answer = answer - num;
            }

            return answer;
        }
    }
}
