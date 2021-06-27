using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseInteger.Solution solution = new ReverseInteger.Solution();
            var quizAnswer = solution.Reverse(-2147483648);

            Console.WriteLine(quizAnswer);
        }
    }
} 
