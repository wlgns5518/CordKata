using System.Linq;

public class Solution
{
    public string solution(string s)
{
    return string.Join(" ", s
        .Split(' ')
        .Select(word => string.IsNullOrEmpty(word) 
            ? word 
            : char.ToUpper(word[0]) + word.Substring(1).ToLower()));
}
}