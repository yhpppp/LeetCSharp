using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: numbers = [2,3,4], target = 6
    //Output: [1,3]
    //Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3.We return [1, 3].
    public class _167_Two_Sum_II___Input_Array_Is_Sorted
    {
        public int[] TwoSum1(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i + 1, j + 1 };
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        public int[] TwoSum2(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int twoValue = target - numbers[i];
                var result = BinarySearch(ref numbers, i + 1, numbers.Length - 1, twoValue);
                if (result != -1)
                {
                    return new int[] { i + 1, result + 1 };
                }
            }
            return new int[] { -1, -1 };
        }

        private int BinarySearch(ref int[] numbers, int l, int r, int target)
        {
            while (l <= r)
            {
                int midIndex = l + (r - l) / 2;
                int midValue = numbers[midIndex];
                if (midValue == target)
                {
                    return midIndex;
                }
                else if (midValue < target)
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

        public int[] TwoSum3(int[] numbers, int target)
        {
            int l = 0;
            int r = numbers.Length - 1;

            while (l <= r)
            {
                if (numbers[l] + numbers[r] == target)
                {
                    return new int[] { l + 1, r + 1 };
                }
                else if (numbers[l] + numbers[r] < target)
                {
                    l++;
                }else
                {
                    r--;
                }
            }
            return new int[] { -1,-1 };
        }
    }
}
