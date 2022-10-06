/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/87390
 */

namespace CutArray
{
    public class Solution
    {
        public ulong[] solution(int n, long left, long right)
        {
            ulong line = (ulong)(left % n + 1);
            ulong row = (ulong)((left / n) + 1);

            ulong[] answer = new ulong[right - left + 1];
            for (ulong i = 0; i < (ulong)answer.Length; i++)
            {
                if(line <= row)
                {
                    answer[i] = row;
                }

                else
                {
                    answer[i] = line;
                }

                line++;
                if(line > (ulong)n)
                {
                    line = 1;
                    row++;
                }
            }

            return answer;
        }
    }
}
