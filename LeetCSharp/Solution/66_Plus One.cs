using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    //Input: digits = [9]
    //Output: [1,0]
    //Explanation: The array represents the integer 9.
    //Incrementing by one gives 9 + 1 = 10.
    //Thus, the result should be[1, 0].
    public class _66_Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>();
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int item = digits[i] + carry;
                carry = item == 10 ? 1 : 0;
                result.Insert(0, item % 10);
            }

            if (carry == 1)
            {
                result.Insert(0, 1);
            }
            return result.ToArray();
        }
    }
}
