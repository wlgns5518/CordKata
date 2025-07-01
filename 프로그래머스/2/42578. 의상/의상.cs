using System;
using System.Collections.Generic;

public class Solution {
     public int solution(string[,] clothes)
 {
     int answer = 1;
     var clothesDict = new Dictionary<string, int>();
     for (int i = 0; i < clothes.GetLength(0); i++)
     {
         if (clothesDict.ContainsKey(clothes[i, 1]))
             clothesDict[clothes[i, 1]]++;
         else
             clothesDict[clothes[i, 1]] = 1;
     }
     foreach (var count in clothesDict.Values)
     {
         answer *= (count + 1);
     }
     return answer - 1;
 }
}