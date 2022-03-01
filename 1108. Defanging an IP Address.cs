public class Solution 
{
    public string DefangIPaddr(string address)
	{
		var addressParts = address.Split('.');

		return string.Join("[.]", addressParts);
    }
}