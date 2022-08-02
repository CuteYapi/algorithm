using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] problem = { 1,2,7,4,6,998,999, 1000 };

            MakePrimeNumber.Solution solution = new MakePrimeNumber.Solution();

            Console.WriteLine(solution.solution(problem));
        }
    }
}

