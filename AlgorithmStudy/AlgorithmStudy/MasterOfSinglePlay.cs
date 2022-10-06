/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/131130
 */

using System.Collections.Generic;
using System.Linq;

namespace MasterOfSinglePlay
{
    public class Solution
    {
        public int solution(int[] cards)
        {
            List<int> deck = new List<int>();
            List<int> count = new List<int>();

            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == 0)
                {
                    continue;
                }

                deck.Clear();
                int order = i;
                while (cards[order] > 0)
                {
                    deck.Add(cards[order]);
                    int temp = cards[order];
                    cards[order] = 0;
                    order = temp - 1;
                }
                count.Add(deck.Count);
            }

            if(count.Count > 1)
            {
                count = count.OrderByDescending(x => x).ToList();
                return count[0] * count[1];
            }
            else
            {
                return 0;
            }
        }
    }
}
