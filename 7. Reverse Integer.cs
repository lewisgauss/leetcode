public class Solution 
{
    public int Reverse(int x) 
	{
        var numberString = x.ToString();
        string reversedValue = "";
        for(var i = numberString.Length - 1; i >= 0; i--) 
        {
			if (i == 0 && numberString[i] == '-')
			{
				reversedValue = "-" + reversedValue;

				break;
			}

            reversedValue += numberString[i];
        }
        
        try 
		{
			return Convert.ToInt32(reversedValue);
		}
		catch (OverflowException ex) 
		{
			return 0;
		}
    }
}