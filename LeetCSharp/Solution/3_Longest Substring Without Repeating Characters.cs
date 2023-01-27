namespace LeetCSharp.Array
{
  // Input: s = "abcabcbb"
  // Output: 3
  // Explanation: The answer is "abc", with the length of 3.
  public class _3_Longest_Substring_Without_Repeating_Characters
  {
    public int LengthOfLongestSubstring(string s)
    {
      int i = 0;
      int j = -1;
      HashSet<char> set = new HashSet<char>();
      int maxLen = 0;
      while (i < s.Length)
      {
        if (j + 1 < s.Length && !set.Contains(s[j + 1]))
        {
          j++;
          set.Add(s[j]);
        }
        else
        {
          set.Remove(s[i]);
          i++;
        }
        maxLen = Math.Max(maxLen, j - i + 1);
      }

      return maxLen;
    }
  }

}