namespace LeetCSharp.Array
{
  // Input: pattern = "abba", s = "dog cat cat dog"
  // Output: true
  public class _290_Word_Pattern
  {
    public bool WordPattern(string pattern, string s)
    {
      string[] words = s.Split(' ');
      if (words.Length != pattern.Length)
      {
        return false;
      }

      Dictionary<char, string> dic1 = new Dictionary<char, string>();
      Dictionary<string, char> dic2 = new Dictionary<string, char>();

      for (int i = 0; i < words.Length; i++)
      {
        if (dic1.ContainsKey(pattern[i]))
        {
          string word = words[i];
          if (dic1[pattern[i]] != word)
          {
            return false;
          }
        }
        else
        {
          if (dic2.ContainsKey(words[i]))
          {
            return false;
          }
          dic1[pattern[i]] = words[i];
          dic2[words[i]] = pattern[i];
        }
      }

      return true;
    }
  }
}