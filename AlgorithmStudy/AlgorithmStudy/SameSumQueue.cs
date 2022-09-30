/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/118667
 */

namespace SameSumQueue
{
    public class Solution
    {
        public int solution(int[] _queue1, int[] _queue2)
        {
            int[] totalQueue = new int[_queue1.Length * 2];
            int i = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;

            foreach (var item in _queue1)
            {
                totalQueue[i] = _queue1[i];
                sum1 += _queue1[i];
                i++;
            }

            foreach (var item in _queue2)
            {
                totalQueue[i] = _queue2[i - _queue1.Length];
                sum2 += _queue2[i - _queue1.Length];
                i++;
            }

            decimal avg = (sum1 + sum2) / 2;
            i = 0;
            int j = _queue1.Length;
            int count = 0;

            while (avg != sum1)
            {
                if (count > totalQueue.Length * 2)
                {
                    return -1;
                }

                if (sum1 < avg)
                {
                    sum1 += totalQueue[j];
                    j++;
                    count++;
                    if (j == totalQueue.Length)
                    {
                        j = 0;
                    }
                }

                else
                {
                    sum1 -= totalQueue[i];
                    i++;
                    count++;
                    if (i == totalQueue.Length)
                    {
                        i = 0;
                    }
                }
            }

            return count;
        }
    }
}
