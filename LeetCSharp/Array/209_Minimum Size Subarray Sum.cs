namespace LeetCSharp.Array
{
  // Input: target = 7, nums = [2,3,1,2,4,3]
  // Output: 2
  // Explanation: The subarray [4,3] has the minimal length under the problem constraint.
  public class _209_Minimum_Size_Subarray_Sum
  {
    // O(n^2)
    public int MinSubArrayLen1(int target, int[] nums)
    {
      int minLen = int.MaxValue;
      for (int i = 0; i < nums.Length; i++)
      {
        int sum = 0;
        for (int j = i; j < nums.Length; j++)
        {
          sum += nums[j];
          if (sum >= target)
          {
            int len = j - i + 1;
            minLen = Math.Min(minLen, len);
            break;
          }
        }
      }
      return minLen == int.MaxValue ? 0 : minLen;
    }

    // O(n)
    public int MinSubArrayLen2(int target, int[] nums)
    {
      int i = 0;
      int j = -1;
      int minLen = int.MaxValue;
      int sum = 0;
      while (i < nums.Length)
      {
        if (j + 1 < nums.Length && sum < target)
        {
          j++;
          sum += nums[j];
        }
        else
        {
          sum -= nums[i];
          i++;
        }

        if (sum >= target)
        {
          minLen = Math.Min(minLen, j - i + 1);
        }
      }

      return minLen == int.MaxValue ? 0 : minLen;
    }
  }
}