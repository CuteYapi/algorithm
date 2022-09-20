using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value1 = { 93, 30, 55 };
            int[] value2 = { 1, 30, 5 };

            FunctionDevelop.Solution solution = new FunctionDevelop.Solution();

            int i = 0;
            while(solution.solution(value1, value2) != null)
            {
                Console.WriteLine(solution.solution(value1, value2)[i]);
                i++;
            }
        }
    }
}

