using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 91354987;
            var Value2 = 3;

            FindPrimeNumberWithK.Solution solution = new FindPrimeNumberWithK.Solution();

            Console.WriteLine(solution.solution(value1, Value2));
        }
    }
}

