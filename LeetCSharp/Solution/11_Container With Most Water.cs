using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Array
{
    //Input: height = [1,8,6,2,5,4,8,3,7]
    //Output: 49    
    // (9-2)*7=49
    public class _11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int l = 0;
            int r = height.Length-1;
            int maxResult = 0;
            while (l < r)
            {
                int result = (r - l) * Math.Min(height[l], height[r]);
                maxResult = Math.Max(maxResult, result);
                if (height[l] <= height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return maxResult;
        }
    }
}
