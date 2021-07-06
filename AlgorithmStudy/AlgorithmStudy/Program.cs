using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr1 = "codeleet";
            int[] arr2 = { 4,5,6,7,0,2,1,3 };

            ShuffleString.Solution solution = new ShuffleString.Solution();


            string answer = solution.RestoreString(arr1, arr2);
            Console.WriteLine(answer);
            
        }
    }
}

