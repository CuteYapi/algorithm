﻿
namespace TwoSum
{
    class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] targetNums = { i, j };
                        return targetNums;
                    }
                }
            }

            return null;
        }
    }
}
