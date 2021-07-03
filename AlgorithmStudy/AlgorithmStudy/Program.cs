using System;

using Implementstrstr;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack = "mississippi";
            string needle = "issipi";

            Implementstrstr.Solution solution = new Implementstrstr.Solution();
            Console.WriteLine(solution.StrStr(haystack, needle));
        }
    }
}

