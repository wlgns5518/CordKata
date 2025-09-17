using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        var list = new List<int>();
        for(int i=0;i<intervals.GetLength(0);i++)
        {
            for(int j=intervals[i,0];j<=intervals[i,1];j++)
            {
                 list.Add(arr[j]);
            }
        }
        return list.ToArray();
    }
}