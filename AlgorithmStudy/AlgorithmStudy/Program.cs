using System;

//using ReverseLinkedList;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListNode l1 = new ListNode(1);
            //l1.next = new ListNode(2);
            //l1.next.next = new ListNode(3);
            //l1.next.next.next = new ListNode(4);
            //l1.next.next.next.next = new ListNode(5);

            //ReverseLinkedList.Solution solution = new ReverseLinkedList.Solution();
            //var quizAnswer = solution.ReverseList(l1);

            //while(!(quizAnswer == null))
            //{
            //    Console.WriteLine(quizAnswer.val);
            //    quizAnswer = quizAnswer.next;
            //}

            HappyNumber.Solution solution = new HappyNumber.Solution();
            var quizAnswer = solution.IsHappy(19);

            Console.WriteLine(quizAnswer);

        }
    }
}

