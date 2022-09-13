using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 10000;

            FibonacciDivision.Solution solution = new FibonacciDivision.Solution();

            Console.WriteLine(solution.solution(s));
        }
    }
}

