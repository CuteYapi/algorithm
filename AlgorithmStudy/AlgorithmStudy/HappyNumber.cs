using System.Collections.Generic;

namespace HappyNumber
{
    class Solution
    {
        public bool IsHappy(int n)
        {

            int sum = 0;
            int target = 0;
            List<int> sumList = new List<int>();

            while (true)
            {
                while (n > 0)
                {
                    target = n % 10;
                    sum += (target * target);
                    n = n / 10;
                }

                foreach (var item in sumList)
                {
                    if (item == sum)
                    {
                        return false;
                    }
                }

                if (sum == 1)
                {
                    return true;
                }

                else
                {
                    sumList.Add(sum);
                    n = sum;
                    target = 0;
                    sum = 0;
                }
            }

        }
    }
}
