using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 5;

            EuclideanAlgorithm.Solution solution = new EuclideanAlgorithm.Solution();

            Console.WriteLine(solution.solution(n, m));
        }
    }
}

