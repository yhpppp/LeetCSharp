using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    public class _75_Sort_Colors
    {
        //Input: nums = [2, 0, 2, 1, 1, 0]
        //Output: [0,0,1,1,2,2]
        public void SortColors1(int[] nums)
        {
            //We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
            int[] count = { 0, 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            int index = 0;
            for (int i = 0; i < count[0]; i++)
            {
                nums[index++] = 0;
            }
            for (int i = 0; i < count[1]; i++)
            {
                nums[index++] = 1;
            }
            for (int i = 0; i < count[2]; i++)
            {
                nums[index++] = 2;
            }
        }

        public void SortColors2(int[] nums)
        {
            int zero = -1;
            int two = nums.Length;
            int i = 0;
            while (i < two)
            {
                if (nums[i] == 0)
                {
                    zero++;
                    Sort(ref nums, i, zero);
                    i++;
                }
                else if (nums[i] == 1)
                {
                    i++;
                }
                else
                {
                    two--;
                    Sort(ref nums, i, two);
                }
            }
        }

        private void Sort(ref int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
