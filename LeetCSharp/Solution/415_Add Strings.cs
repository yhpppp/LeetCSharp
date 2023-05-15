using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCSharp.Solution
{
    public class _415_Add_Strings
    {
        //Input: num1 = "11", num2 = "123"
        //Output: "134"
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int saveNum = 0;
            while (i >= 0 && j >= 0)
            {
                int value = num1[i--] - '0' + num2[j--] - '0' + saveNum;
                int digit = value % 10;
                saveNum = value / 10;
                sb.Append(digit);
            }

            while (i >= 0)
            {
                int value = num1[i--] - '0' + saveNum;
                int digit = value % 10;
                saveNum = value / 10;
                sb.Append(digit);
            }
            while (j >= 0)
            {
                int value = num2[j--] - '0' + saveNum;
                int digit = value % 10;
                saveNum = value / 10;
                sb.Append(digit);
            }

            if (saveNum > 0)
            {
                sb.Append(saveNum);
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
