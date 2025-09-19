using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag)
{
    var answer = new List<int>();
    for (int i = 0; i < flag.Length; i++)
    {
        if (flag[i])
        {
            for (int j = 0; j < arr[i]*2; j++)
                answer.Add(arr[i]);
        }
        else
        {
            for(int j = 0; j < arr[i] ; j++)
            {
                answer.RemoveAt(answer.Count-1); // 마지막 요소 하나씩 제거
            }
        }
    }
    return answer.ToArray();
}
}