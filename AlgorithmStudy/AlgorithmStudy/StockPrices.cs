/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42584
 */

using System.Collections.Generic;

namespace StockPrices
{
    public class Solution
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];

            for (int i = 0; i < prices.Length - 1; i++)
            {
                Stack<int> stockValue = new Stack<int>();
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] <= prices[j])
                    {
                        stockValue.Push(prices[j]);
                    }

                    else
                    {
                        stockValue.Push(prices[j]);
                        break;
                    }
                }
                answer[i] = stockValue.Count;
            }

            answer[answer.Length - 1] = 0;

            return answer;
        }
    }
}
