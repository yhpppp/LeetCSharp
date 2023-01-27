using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    //Output: [1,2,2,3,5,6]
    public class _88_Merge_Sorted_Array
    {
        public void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }

            System.Array.Sort(nums1);
        }

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int[] temp = new int[m + n];
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    temp[k] = nums1[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = nums2[j];
                    j++;
                    k++;
                }
            }

            while (i < m)
            {
                temp[k] = nums1[i];
                i++;
                k++;
            }

            while (j < n)
            {
                temp[k] = nums2[j];
                j++;
                k++;
            }

            for (int index = 0; index < m + n; index++)
            {
                nums1[index] = temp[index];
            }
        }
    }
}
