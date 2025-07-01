using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes)
{
    int answer = 1;
    var clothesDict = new Dictionary<string, int>();
    for (int i = 0; i < clothes.GetLength(0); i++)
    {
        string type = clothes[i, 1];
        if (clothesDict.ContainsKey(type))
            clothesDict[type]++;
        else
            clothesDict[type] = 1;
    }
    foreach (var count in clothesDict.Values)
    {
        answer *= (count + 1);
    }
    return answer - 1;
}
}