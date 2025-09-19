using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        var answer = new List<int>();
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<arr[i];j++)
                answer.Add(arr[i]);
        }
        return answer.ToArray();
    }
}