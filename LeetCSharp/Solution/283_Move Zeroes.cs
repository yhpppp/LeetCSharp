using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    public class _283_Move_Zeroes
    {
        //Input: nums = [0,1,0,3,12]
        //Output: [1,3,12,0,0]
        //Input: nums = [0]
        //Output: [0]
        public void MoveZeroes1(int[] nums)
        {
            //Note that you must do this in-place without making a copy of the array.
            List<int> list = new List<int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    list.Add(nums[i]);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                nums[i] = list[i];
            }

            for (int i = list.Count; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public void MoveZeroes2(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j++;
                }
            }
        }

        //Follow up: Could you minimize the total number of operations done?
        //1 3 4 6 0 1
        public void MoveZeroes3(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i != j)
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        j++;
                    }
                    else { j++; }

                }
            }
        }

        public void MoveZeroes4(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            for (int i = j; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
