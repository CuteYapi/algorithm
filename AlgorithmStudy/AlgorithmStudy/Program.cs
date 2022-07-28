using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] id_list = { "muzi", "frodo", "apeach", "neo" };
            string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k = 2;

            ReportResult.Solution solution = new ReportResult.Solution();

            Console.WriteLine(solution.solution(id_list, report, k));
        }
    }
}

