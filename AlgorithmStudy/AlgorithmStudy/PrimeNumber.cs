/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12921
 */

using System;
using System.Collections.Generic;

namespace PrimeNumber
{
    public class Solution
    {
        public int solution(int n)
        {
            List<int> primeNumber = new List<int>();

            if(n==2)
            {
                return 1;
            }

            if(n==3)
            {
                return 2;
            }

            primeNumber.Add(2);
            primeNumber.Add(3);

            for (int i = 4; i <= n; i++)
            {
                for (int j = 0; j < primeNumber.Count; j++)
                {
                    if (i % primeNumber[j] == 0)
                    {
                        break;
                    }

                    if (primeNumber[j + 1] > Math.Sqrt(i))
                    {
                        primeNumber.Add(i);
                        break;
                    }
                }
            }
            return primeNumber.Count;
        }
    }
}
