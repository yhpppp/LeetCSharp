﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: nums = [1,2,3]
    //Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
    public class _78_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            return SubsetsRecursion(nums, nums.Length);
        }

        public IList<IList<int>> SubsetsRecursion(int[] nums, int len)
        {
            if (len == 0)
            {
                return new List<IList<int>>() { new List<int>() };
            }
            else
            {
                int last = nums[len - 1];

                IList<IList<int>> res = SubsetsRecursion(nums, len - 1);

                int size = res.Count;
                for (int i = 0; i < size; i++)
                {
                    IList<int> sub = res[i];
                    IList<int> newSUb = new List<int>(sub);
                    newSUb.Add(last);
                    res.Add(newSUb);
                }
                return res;
            }
        }
    }
}
