/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42586
 */

using System.Collections.Generic;

namespace FunctionDevelop
{
    public class Solution
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            Queue<Function> developQueue = new Queue<Function>();

            for (int i = 0; i < progresses.Length; i++)
            {
                Function function = new Function();
                function.progress = progresses[i];
                function.speed = speeds[i];

                developQueue.Enqueue(function);
            }

            List<int> doneSameTime = new List<int>();
            doneSameTime.Add(0);

            while (developQueue.Count > 0)
            {
                if(developQueue.Peek().developDone)
                {
                    developQueue.Dequeue();
                    doneSameTime[doneSameTime.Count - 1]++;
                    continue;
                }

                foreach (var item in developQueue)
                {
                    item.develop();
                }

                if (doneSameTime[doneSameTime.Count - 1] != 0)
                {
                    doneSameTime.Add(0);
                }
            }

            int[] answer = new int[doneSameTime.Count];
            for (int i = 0; i < doneSameTime.Count; i++)
            {
                answer[i] = doneSameTime[i];
            }

            return answer;
        }
    }

    public class Function
    {
        public int progress;
        public int speed;
        public bool developDone = false;

        public void develop()
        {
            progress += speed;
            if (progress >= 100) { developDone = true; }
        }
    }
}
