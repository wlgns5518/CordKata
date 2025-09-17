using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        List<int> answer = arr.ToList();

        for (int i = 0; i < query.Length; i++)
        {
            int q = query[i];
            if (i % 2 == 0)
                answer.RemoveRange(q + 1, answer.Count() - (q + 1));
            else
                answer.RemoveRange(0, q);
        }
        return answer.ToArray();
    }
}