/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42748?language=csharp
 */

using System.Collections.Generic;

namespace K_thNumber
{
    public class Solution
    {
        private class answerArray
        {
            public List<int> array = new List<int>();
        }

        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.Length / 3];

            List<answerArray> answerArrays = new List<answerArray>();

            for (int i = 0; i < commands.Length / 3; i++)
            {
                answerArray addAnswer = new answerArray();
                for (int j = 0; j < commands[i,1] - commands[i,0] + 1; j++)
                {
                    addAnswer.array.Add(array[(commands[i,0] - 1) + j]);
                }
                answerArrays.Add(addAnswer);
            }

            for (int i = 0; i < answerArrays.Count; i++)
            {
                answerArrays[i].array.Sort();
                answer[i] = answerArrays[i].array[commands[i,2] - 1];
            }

            return answer;
        }
    }
}
