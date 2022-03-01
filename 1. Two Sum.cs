public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
	{
		// Value, Index
		var dictionaryCache = new Dictionary<int, int>();

		for (var i = 0; i < nums.Length; i++) 
		{
			var thisComplement = target - nums[i];

			if (dictionaryCache.TryGetValue(thisComplement, out var index))
			{
				return new []
				{
					index,
					i
				};
			}

			if (!dictionaryCache.ContainsKey(nums[i]))
			{
				dictionaryCache.Add(nums[i], i);
			}
		}

		return Array.Empty<int>();
    }
}