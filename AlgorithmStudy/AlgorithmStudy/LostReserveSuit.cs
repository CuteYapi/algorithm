/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/42862
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostReserveSuit
{
    public class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            List<int> lostList = lost.ToList();
            List<int> reserveList = reserve.ToList();

            lostList.Sort();
            reserveList.Sort();

            int returnNumber = 0;

            #region 아래서부터 탐색
            for (int i = 0; i < lostList.Count; i++)
            {
                if (reserveList.Contains(lostList[i]))
                {
                    reserveList.Remove(lostList[i]);
                    lostList.Remove(lostList[i]);
                }
            }

            for (int i = 0; i < lostList.Count; i++)
            {
                if (reserveList.Contains(lostList[i] - 1))
                {
                    reserveList.Remove(lostList[i] - 1);
                    lostList.Remove(lostList[i]);
                }

                else if (reserveList.Contains(lostList[i] + 1))
                {
                    reserveList.Remove(lostList[i] + 1);
                    lostList.Remove(lostList[i]);
                }
            }

            returnNumber = n - lostList.Count;

            #endregion

            #region 위에서부터 탐색
            lostList = lost.ToList();
            reserveList = reserve.ToList();

            lostList.Sort();
            reserveList.Sort();

            for (int i = lostList.Count - 1; i >= 0; i--)
            {
                if (reserveList.Contains(lostList[i]))
                {
                    reserveList.Remove(lostList[i]);
                    lostList.Remove(lostList[i]);
                }
            }

            for (int i = lostList.Count - 1; i >= 0; i--)
            {
                if (reserveList.Contains(lostList[i] + 1))
                {
                    reserveList.Remove(lostList[i] + 1);
                    lostList.Remove(lostList[i]);
                }

                else if (reserveList.Contains(lostList[i] - 1))
                {
                    reserveList.Remove(lostList[i] - 1);
                    lostList.Remove(lostList[i]);
                }
            }

            if (returnNumber < n - lostList.Count)
            {
                returnNumber = n - lostList.Count;
            }
            #endregion

            return returnNumber;
        }
    }
}
