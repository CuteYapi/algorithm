/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12935
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMinDestroy
{
    public class Solution
    {
        public List<int> solution(int[] arr)
        {
            List<int> result = new List<int>();
            result = arr.ToList();

            result.Remove(result.Min());

            if(result.Count == 0)
            { result.Add(-1); }
            return result;
        }
    }
}
