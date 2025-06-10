using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds)
{
    List<int> answer = new List<int>();
    int n = progresses.Length;
    int[] days = new int[n];

    // 각 기능이 완료되기까지 걸리는 일수 계산
    for (int i = 0; i < n; i++)
    {
        int remain = 100 - progresses[i];
        days[i] = (int)Math.Ceiling((double)remain / speeds[i]);
    }

    int deployDay = days[0];
    int count = 1;

    for (int i = 1; i < n; i++)
    {
        if (days[i] <= deployDay)
        {
            count++;
        }
        else
        {
            answer.Add(count);
            deployDay = days[i];
            count = 1;
        }
    }
    answer.Add(count);

    return answer.ToArray();
}
}