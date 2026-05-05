namespace LeetCodeTasks
{
  class Program
  {
    public static void Main(string[] args)
    {
      var sumTwo = new SumTwo();
      int[] nums = [2, 11, 7, 15];
      var target = 9;
      int[] result = sumTwo.TwoSum(nums, target);
      foreach (var t in result)
      {
        Console.WriteLine(t);
      }

    }
  }
}