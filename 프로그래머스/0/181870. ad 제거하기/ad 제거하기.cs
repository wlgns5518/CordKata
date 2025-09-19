using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr)
{
    var answer = new List<string>();
    for(int i=0;i<strArr.Length;i++)
    {
        if (!strArr[i].Contains("ad"))
            answer.Add(strArr[i]);
    }
    return answer.ToArray();
}
}