namespace LeetCSharp.Array
{
  // Input: nums1 = [1,2,2,1], nums2 = [1,2,2]
  // Output: [1,2,2]
  public class _350_Intersection_of_Two_Arrays_II
  {
    public int[] Intersect(int[] nums1, int[] nums2)
    {
      Dictionary<int, int> dic = new Dictionary<int, int>();
      foreach (var item in nums1)
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
      List<int> list = new List<int>();
      foreach (var item in nums2)
      {
        if (dic.ContainsKey(item) && dic[item] > 0)
        {
          list.Add(item);
          dic[item]--;
        }
      }
      return list.ToArray();
    }
  }
}