using System;

public class Solution
{
    public int solution(int[] citations)
    {
        int answer = 0;
        int n = citations.Length;
        for (int h = 0; h <= n; h++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (citations[i] >= h)
                    count++;
            }
            if (count >= h)
                answer = h;
        }
        return answer;
    }
}