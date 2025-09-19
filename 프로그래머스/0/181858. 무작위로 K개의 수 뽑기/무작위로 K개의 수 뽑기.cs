using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        List<int> answerList = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in arr)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                answerList.Add(num);
                if (answerList.Count == k) break;
            }
        }

        // 부족하면 -1로 채우기
        while (answerList.Count < k)
            answerList.Add(-1);

        return answerList.ToArray();
    }
}