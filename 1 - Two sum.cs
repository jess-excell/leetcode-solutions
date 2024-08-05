public class Solution
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// </summary>
    public int[] TwoSum(int[] nums, int target)
    {
        for (int firstIndex = 0; firstIndex < nums.Length; firstIndex++)
        {
            int secondIndex = 0;
            while (secondIndex < nums.Length)
            {
                if (firstIndex == secondIndex)
                {
                    secondIndex++;
                }
                if (nums[firstIndex] + nums[secondIndex] == target)
                {
                    return [firstIndex, secondIndex];
                }
                secondIndex++;
            }
        }
        return [];
    }
}
