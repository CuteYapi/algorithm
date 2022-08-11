using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Z";
            int n = 10;

            CaesarCipher.Solution solution = new CaesarCipher.Solution();

            Console.WriteLine(solution.solution(s,n) + "//");
        }
    }
}

