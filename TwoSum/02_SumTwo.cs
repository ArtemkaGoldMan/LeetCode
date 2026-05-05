namespace LeetCodeTasks
{
  public class SumTwo()
  {
    public int[] TwoSum(int[] nums, int target)
    {
      int[] answer = new int[2];
      Dictionary<int, int> dict = new Dictionary<int, int>();

      for (int i = 0; i < nums.Length; i++)
      {
        dict[nums[i]] = i;
      }

      for (int i = 0; i < nums.Length; i++)
      {
        int look = target - nums[i];
        if (dict.ContainsKey(look) && dict[look] != i)
        {
          answer[0] = i;
          answer[1] = dict[look];
        }
      }

      return answer;
    }

  }
}