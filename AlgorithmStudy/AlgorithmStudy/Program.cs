using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] absolutes = {4,7,12};
            bool[] signs = {false, false, true};

            PlusMinus.Solution solution = new PlusMinus.Solution();

            Console.WriteLine(solution.solution(absolutes, signs));
        }
    }
}

