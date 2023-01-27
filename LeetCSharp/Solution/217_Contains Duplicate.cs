
namespace LeetCSharp.Array
{
  // Input: nums = [1,2,3,1]
  // Output: true
  public class _217_Contains_Duplicate
  {
    // sort
    public bool ContainsDuplicate1(int[] nums)
    {
      System.Array.Sort(nums);
      for (int i = 0; i < nums.Length - 1; i++)
      {
        if (nums[i] == nums[i + 1])
        {
          return true;
        }
      }
      return false;
    }

    // set
    public bool ContainsDuplicate2(int[] nums)
    {
      HashSet<int> set = new HashSet<int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (!set.Add(nums[i]))
        {
          return true;
        }
      }
      return false;
    }
  }
}