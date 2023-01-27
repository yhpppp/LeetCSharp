namespace LeetCSharp.Array
{
  // Input: strs = ["eat","tea","tan","ate","nat","bat"]
  // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
  public class _49_Group_Anagrams
  {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
      Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
      for (int i = 0; i < strs.Length; i++)
      {
        char[] chars = strs[i].ToCharArray();
        System.Array.Sort(chars);
        string key = new string(chars);

        if (!map.ContainsKey(key))
        {
          map.Add(key, new List<string>());
        }

        map[key].Add(strs[i]);
      }

      return new List<IList<string>>(map.Values);
    }
  }
}
