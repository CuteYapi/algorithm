/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/92334
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportResult
{
    public class Solution
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            List<IdReport> idReport = new List<IdReport>();

            foreach (var item in id_list)
            {
                IdReport newID = new IdReport();
                newID.id = item;

                idReport.Add(newID);
            }

            foreach (var item in report)
            {
                string[] splitString = item.Split(' ');

                IdReport targetIDReport = idReport.Find(x => x.id == splitString[0]);
                if (targetIDReport.report == null || !targetIDReport.report.Contains(splitString[1]))
                {
                    targetIDReport.report.Add(splitString[1]);
                    idReport.Find(x => x.id == splitString[1]).reportedCount++;
                }
            }

            List<string> bannedID = new List<string>();
            foreach (var item in idReport)
            {
                if(item.reportedCount >= k)
                {
                    bannedID.Add(item.id);
                }
            }

            for (int i = 0; i < idReport.Count; i++)
            {
                foreach (var item in bannedID)
                {
                    if (idReport[i].report.Contains(item))
                    {
                        idReport[i].reportCount++;
                    }
                }
            }

            for (int i = 0; i < idReport.Count; i++)
            {
                answer[i] = idReport[i].reportCount;
            }

            return answer;
        }
    }

    public class IdReport
    {
        public string id;
        public List<string> report = new List<string>();
        public int reportedCount;
        public int reportCount;
    }
}
