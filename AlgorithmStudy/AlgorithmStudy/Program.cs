using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MergeTwoSortedLists;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
           // l1.next = new ListNode(2);
            //l1.next.next = new ListNode(5);

            ListNode l2 = new ListNode(2);
            //l2.next = new ListNode(3);
            //l2.next.next = new ListNode(4);

            MergeTwoSortedLists.Solution solution = new MergeTwoSortedLists.Solution();
            var quizAnswer = solution.MergeTwoLists(l1, l2);

            while (!(quizAnswer == null))
            {
                Console.WriteLine(quizAnswer.val);
                quizAnswer = quizAnswer.next;
            }
        }
    }
} 
