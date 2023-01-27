
using System.Collections.Generic;
using System.Text;


namespace LeetCSharp.Solution
{
    //Input: s = "tree"
    //Output: "eert"
    //Explanation: 'e' appears twice while 'r' and 't' both appear once.
    //So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
    internal class _451_Sort_Characters_By_Frequency
    {
        public string FrequencySort1(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char item in s)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            //sort
            IOrderedEnumerable<KeyValuePair<char, int>> sortDic = dic.OrderByDescending(x => x.Value);
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<char, int> item in sortDic)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    sb.Append(item.Key);
                }
            }
            return sb.ToString();
        }

        public string FrequencySort2(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char item in s)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            List<APair> list = new List<APair>();

            foreach (KeyValuePair<char, int> item in dic)
            {
                char key = item.Key;
                int value = item.Value;
                list.Add(new APair(key, value));
            }
            list.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (APair item in list)
            {
                for (int i = 0; i < item.value; i++)
                {
                    sb.Append(item.key);
                }
            }
            return sb.ToString();
        }

    }

    public class APair : IComparable<APair>
    {
        public char key;
        public int value;

        public APair(char key, int value)
        {
            this.key = key;
            this.value = value;
        }

        public int CompareTo(APair? other)
        {
            return other.value - this.value;
        }
    }
}
