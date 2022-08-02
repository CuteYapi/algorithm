using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            K_thNumber.Solution solution = new K_thNumber.Solution();

            int[] answer = solution.solution(array, commands);
            foreach (var item in answer)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

