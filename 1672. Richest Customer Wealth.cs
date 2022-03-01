public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
	{
		var richestWealth = 0;

        for (var i = 0; i < accounts.GetLength(0); i++)
		{
			var thisCustomerWealth = accounts[i];

			var sumOfWealth = 0;

			for (var j = 0; j < thisCustomerWealth.Length; j++)
			{
				sumOfWealth = sumOfWealth + thisCustomerWealth[j];
			}

			if (sumOfWealth > richestWealth) 
			{
				richestWealth = sumOfWealth;
			}
		}

		return richestWealth;
    }
}