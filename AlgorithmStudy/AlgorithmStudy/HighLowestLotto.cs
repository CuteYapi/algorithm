/* https://school.programmers.co.kr/learn/courses/30/lessons/77484
 * 
 * 
 * */

namespace HighLowestLotto
{
    public class Solution
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[] { };
            answer = new int[2];
            int countZero = 0;
            int countCorrect = 0;

            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    countZero++;
                    continue;
                }

                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j])
                    {
                        countCorrect++;
                        break;
                    }
                }
            }

            answer[0] = setRate(countCorrect + countZero);
            answer[1] = setRate(countCorrect);

            return answer;
        }

        private int setRate(int correctNumber)
        {
            switch (correctNumber)
            {
                case 0:
                case 1:
                    return 6;
                case 2:
                    return 5;
                case 3:
                    return 4;
                case 4:
                    return 3;
                case 5:
                    return 2;
                case 6:
                    return 1;
            }
            return 0;
        }
    }
}
