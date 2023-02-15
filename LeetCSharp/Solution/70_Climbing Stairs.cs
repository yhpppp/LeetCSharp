using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: n = 3
    //Output: 3
    //Explanation: There are three ways to climb to the top.
    //1. 1 step + 1 step + 1 step
    //2. 1 step + 2 steps
    //3. 2 steps + 1 step
    public class _70_Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) { return 1; }
            if (n == 2) { return 2; }

            int[] ints = new int[n];
            ints[0] = 1;
            ints[1] = 2;

            for (int i = 2; i < n; i++)
            {
                ints[i] = ints[i - 2] + ints[i - 1];
            }

            return ints[n - 1];
        }
    }
}
