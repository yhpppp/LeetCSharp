using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: nums = [-1,0,1,2,-1,-4]
    //Output: [[-1,-1,2],[-1,0,1]]
    //Explanation: 
    //nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
    //nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
    //nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
    //The distinct triplets are[-1, 0, 1] and[-1, -1, 2].
    //Notice that the order of the output and the order of the triplets does not matter.
    public class _15_3Sum
    {
        // O(n^3)
        public IList<IList<int>> ThreeSum1(int[] nums)
        {
            int len = nums.Length;
            IList<IList<int>> list = new List<IList<int>>();

            System.Array.Sort(nums);
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0) { break; }
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }
                for (int j = i + 1; j < len; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) { continue; }
                    for (int k = j + 1; k < len; k++)
                    {
                        if (k > j + 1 && nums[k] == nums[k - 1]) { continue; }
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            list.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        }
                    }
                }
            }
            return list;
        }

        // O(n*n*log n)
        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            int len = nums.Length;
            System.Array.Sort(nums);
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0) { break; }
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }
                for (int j = i + 1; j < len; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) { continue; }
                    int three = BinarySearch(ref nums, j + 1, len - 1, 0 - (nums[i] + nums[j]));
                    if (three != -1)
                    {
                        list.Add(new List<int>() { nums[i], nums[j], nums[three] });
                    }
                }
            }
            return list;
        }

        private int BinarySearch(ref int[] nums, int l, int r, int targetValue)
        {
            while (l <= r)
            {
                int midIndex = l + (r - l) / 2;
                int midValue = nums[midIndex];
                if (midValue == targetValue)
                {
                    return midIndex;
                }
                else if (midValue < targetValue)
                {
                    l = midIndex + 1;
                }
                else
                {
                    r = midIndex - 1;
                }
            }
            return -1;
        }

        // O(n*n)
        public IList<IList<int>> ThreeSum3(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            System.Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) { break; }
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }
                int l = i + 1;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum == 0)
                    {
                        list.Add(new List<int>() { nums[i], nums[l], nums[r] });

                        while (l < r && nums[l] == nums[l + 1])
                        {
                            l++;
                        }
                        while (l < r && nums[r] == nums[r - 1])
                        {
                            r--;
                        }
                        l++;
                        r--;
                    }else if(sum > 0)
                    {
                        r--;
                    }else if (sum < 0)
                    {
                        l++;
                    }

                }

            }

            return list;
        }

    }
}
