namespace LeetCSharp.Array
{
  // Input: s = "anagram", t = "nagaram"
  // Output: true
  public class _242_Valid_Anagram
  {
    public bool IsAnagram1(string s, string t)
    {
      if (s.Length != t.Length)
      {
        return false;
      }

      var sarray = s.ToCharArray();
      var tarray = t.ToCharArray();
      System.Array.Sort(sarray);
      System.Array.Sort(tarray);

      return sarray.SequenceEqual(tarray);

      // for (int i = 0; i < sarray.Length; i++)
      // {
      //   if (!sarray[i].Equals(tarray[i]))
      //   {
      //     return false;
      //   }
      // }

      // return true;
    }

    public bool IsAnagram2(string s, string t)
    {
      if (s.Length != t.Length) { return false; }

      Dictionary<char, int> dic = new Dictionary<char, int>();
      foreach (char item in s)
      {
        if (!dic.ContainsKey(item))
        {
          dic.Add(item, 1);
        }
        else
        {
          dic[item]++;
        }
      }

      foreach (char item in t)
      {
        if (!dic.ContainsKey(item))
        {
          return false;
        }
        dic[item]--;

        if (dic[item] < 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}