/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12977
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace MakePrimeNumber
{
    public class Solution
    {
        List<int> primeNumber = new List<int>();

        public int solution(int[] nums)
        {
            primeNumber.Add(2);

            List<int> answer = new List<int>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (isPrimeNumber(nums[i] + nums[j] + nums[k]))
                        {
                            answer.Add(nums[i] + nums[j] + nums[k]);
                        }
                    }
                }
            }

            return answer.Count;
        }

        bool isPrimeNumber(int num)
        {
            if (num >= (primeNumber[primeNumber.Count - 1] * primeNumber[primeNumber.Count - 1]))
            {
                FindPrime(num);
            }

            if (primeNumber.Where(x => num % x == 0).FirstOrDefault() == 0
                || primeNumber.Contains(num))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        void FindPrime(int num)
        {
            for (int i = (primeNumber[primeNumber.Count - 1] + 1); i <= Math.Sqrt(num); i++)
            {
                if (primeNumber.Where(x => i % x == 0).FirstOrDefault() == 0)
                {
                    primeNumber.Add(i);
                }
            }
        }
    }
}
