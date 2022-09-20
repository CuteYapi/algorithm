/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42587
 */
using System.Collections.Generic;
using System.Linq;

namespace Printer
{
    public class Solution
    {
        public int solution(int[] priorities, int location)
        {
            int printCount = 0;
            Queue<int> prioritiesQueue = new Queue<int>();
            foreach (var item in priorities)
            {
                prioritiesQueue.Enqueue(item);
            }

            while(prioritiesQueue.Count > 0)
            {
                int item = prioritiesQueue.Dequeue();
                if(prioritiesQueue.Where(x => x > item).Any())
                {
                    prioritiesQueue.Enqueue(item);
                }

                else
                {
                    printCount++;
                    if (location == 0)
                    {
                        return printCount;
                    }
                }

                location--;
                if (location < 0) { location = prioritiesQueue.Count - 1; }
            }

            return -1;
        }
    }
}
