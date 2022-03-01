public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {        
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }
        
        var needleLength = needle.Length;
        var haystackLength = haystack.Length;
        
        if (needleLength > haystackLength) 
        {
            return -1;
        }
        
        for(var i = 0; i < haystackLength; i++) 
        {
            if (haystack[i] == needle[0] && needleLength <= haystackLength - i) 
            {
                if (haystack.Substring(i, needleLength) == needle)
                {
                    return i;
                }
            }    
        }
        
        return -1;
    }
}