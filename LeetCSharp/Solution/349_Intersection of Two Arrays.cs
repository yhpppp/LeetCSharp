namespace LeetCSharp.Array
{
  // Input: nums1 = [1,2,2,1], nums2 = [2,2]
  // Output: [2]
  public class _349_Intersection_of_Two_Arrays
  {
    public int[] Intersection(int[] nums1, int[] nums2)
    {
      HashSet<int> set1 = new HashSet<int>(nums1);
      HashSet<int> set2 = new HashSet<int>();
      for (int i = 0; i < nums2.Length; i++)
      {
        if (set1.Contains(nums2[i]))
        {
          set2.Add(nums2[i]);
        }
      }
      return set2.ToArray();
    }

  }
}