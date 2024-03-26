using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        List<int> result = new List<int>();
        for(int i=0;i<score.Length;i++)
        {
            if (result.Count == k)
            {
                if (result[0] > score[i])
                {
                    answer[i] = result[0];
                    continue;
                }
                result.RemoveAt(0);
            }
            result.Add(score[i]);
            result.Sort();
            answer[i] = result[0];
        }
        return answer;
    }
}