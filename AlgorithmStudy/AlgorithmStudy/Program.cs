using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 4,1,2,1 };
            int target = 4;

            TargetNumber.Solution solution = new TargetNumber.Solution();

            Console.WriteLine(solution.solution(number, target));
        }
    }
}

