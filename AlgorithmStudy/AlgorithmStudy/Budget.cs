/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12982
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Solution
    {
        public int solution(int[] d, int budget)
        {
            int result = 0;
            int totalD = 0;

            List<int> dList = d.ToList();
            dList.Sort();

            foreach (var value in dList)
            {
                totalD = totalD + value;
                if(totalD > budget)
                {
                    break;
                }
                result++;
            }

            return result;
        }
    }
}
