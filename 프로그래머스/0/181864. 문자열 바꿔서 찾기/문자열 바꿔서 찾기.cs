using System;

public class Solution {
    public int solution(string myString, string pat)
{
    return myString.Replace('A', 'a').Replace('B', 'A').Replace('a', 'B').Contains(pat) ? 1 : 0;
}
}