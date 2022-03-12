public class Solution 
{
    public string IntToRoman(int num) 
    {
        var symbolMaps = new Dictionary<string, int>
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };
        
        var result = string.Empty;
        var remainingNum = num;
        
        foreach (var (symbol, value) in symbolMaps) 
        {
            var countOfSymbol = remainingNum / value;
            
            if (countOfSymbol <= 0) 
            {
                continue;
            }
            
            result += string.Concat(Enumerable.Repeat(symbol, countOfSymbol));
            remainingNum = remainingNum % value;
        }
        
        return result;
    }
}