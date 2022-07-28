/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42840
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    public class Solution
    {
        public List<int> solution(int[] answers)
        {
            List<int> answer = new List<int>();

            int[][] giverAnswer = new int[3][];
            giverAnswer[0] = new int[] { 1, 2, 3, 4, 5 };
            giverAnswer[1] = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            giverAnswer[2] = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int[] giverCorrect = new int[3];

            for (int i = 0; i < giverCorrect.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < answers.Length; j++)
                {
                    if (answers[j] == giverAnswer[i][k])
                    {
                        giverCorrect[i]++;
                    }

                    k++;
                    if (k >= giverAnswer[i].Length)
                    {
                        k = 0;
                    }
                }
            }

            int maxGrade = 0;
            for (int i = 0; i < giverCorrect.Length; i++)
            {
                if (giverCorrect[i] > maxGrade)
                {
                    maxGrade = giverCorrect[i];
                    answer.Clear();
                    answer.Add(i + 1);
                    continue;
                }

                if (giverCorrect[i] == maxGrade)
                {
                    answer.Add(i + 1);
                }
            }

            return answer;
        }
    }
}
