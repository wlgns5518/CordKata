using System;
using System.Linq;

public class Solution
{
    public int[] solution(string myString)
    {
        return myString.Split('x').Select(x => x.Length).ToArray();
    }
}