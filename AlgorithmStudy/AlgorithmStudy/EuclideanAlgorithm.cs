/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12940
 */
namespace EuclideanAlgorithm
{
    public class Solution
    {
        int numN;
        int numM;

        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            if (n < m)
            {
                SetEuclidean(n, m);
            }

            else
            {
                SetEuclidean(m, n);
            }

            answer[0] = numN;
            answer[1] = (n / numN) * (m / numN) * numN;

            return answer;
        }

        void SetEuclidean(int a, int b)
        {
            if (b % a == 0)
            {
                numN = a;
                numM = b;

                return;
            }

            else
            {
                b = b % a;

                if (b < a)
                {
                    int temp;
                    temp = a;
                    a = b;
                    b = temp;
                }

                SetEuclidean(a, b);
            }
        }
    }
}
