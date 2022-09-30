/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/92335
 */

using System;
using System.Collections.Generic;

namespace FindPrimeNumberWithK
{
    public class Solution
    {
        List<ulong> primeNumber = new List<ulong> { 2, 3 };

        public int solution(int n, int k)
        {

            string transNumber = "";
            while (n != 0)
            {
                transNumber = (n % k).ToString() + transNumber;
                n /= k;
            }

            int primeCount = 0;
            string parseNumber = "";
            for (int i = 0; i < transNumber.Length; i++)
            {
                if (transNumber[i] == '0' && parseNumber != "")
                {
                    primeCount += SetPrimeNumber(Convert.ToUInt64(parseNumber));
                    parseNumber = "";
                }

                else if (transNumber[i] != '0')
                {
                    parseNumber += transNumber[i];
                }
            }

            if(parseNumber != "" && parseNumber != "0")
            {
                primeCount += SetPrimeNumber(Convert.ToUInt64(parseNumber));
            }

            return primeCount;
        }

        public int SetPrimeNumber(ulong _number)
        {
            if(_number == 1)
            {
                return 0;
            }

            if (primeNumber[primeNumber.Count - 1] * primeNumber[primeNumber.Count - 1] < _number)
            {
                ulong findNextPrime = primeNumber[primeNumber.Count - 1] + 1;
                bool isPrime = false;
                while (!isPrime)
                {
                    isPrime = true;
                    for (int i = 0; primeNumber[i] * primeNumber[i] <= findNextPrime; i++)
                    {
                        if(findNextPrime % primeNumber[i] == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if(!isPrime)
                    {
                        findNextPrime++;
                    }
                }
                primeNumber.Add(findNextPrime);
                return SetPrimeNumber(_number);
            }

            else
            {
                for (int i = 0; primeNumber[i] * primeNumber[i] <= _number; i++)
                {
                    if (_number % primeNumber[i] == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        }
    }
}
