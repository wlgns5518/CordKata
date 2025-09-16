using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l)
{
    var answer = new List<int>();
    int count = 0;
    for (int i = 0; i < intStrs.Length; i++)
    {
        intStrs[i] = intStrs[i].Substring(s, l);
        if (int.Parse(intStrs[i])>k)
            answer.Add(int.Parse(intStrs[i]));
    }
    return answer.ToArray();
}
}