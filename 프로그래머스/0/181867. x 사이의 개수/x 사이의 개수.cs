using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
   public int[] solution(string myString)
{
    string[] x = myString.Split("x");
    int[] answer = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        answer[i] = x[i].Length;
    }
    return answer.ToArray();
}
}