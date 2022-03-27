namespace Leetcode.Solution.q1;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int value;
            if (hashTable.TryGetValue(target - nums[i], out value))
            {
                return new int[] { value, i };
            }
            hashTable[nums[i]] = i;
        }

        return new int[] { -1, -1 };
    }
}