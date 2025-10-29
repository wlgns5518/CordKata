using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] friends, string[] gifts)
{
    int n = friends.Length;
    int[,] give = new int[n, n]; // give[i,j] = i가 j에게 준 횟수
    int[] giveCount = new int[n]; // 준 총 횟수
    int[] takeCount = new int[n]; // 받은 총 횟수
    int[] nextMonth = new int[n]; // 다음달 받을 선물
    
    // 인덱스 찾기용
    var idx = new Dictionary<string, int>();
    for (int i = 0; i < n; i++)
        idx[friends[i]] = i;
    
    // 선물 기록 처리
    foreach (var gift in gifts)
    {
        var parts = gift.Split();
        int from = idx[parts[0]];
        int to = idx[parts[1]];
        give[from, to]++;
        giveCount[from]++;
        takeCount[to]++;
    }
    
    // 모든 쌍 비교
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (give[i, j] > give[j, i])
                nextMonth[i]++;
            else if (give[j, i] > give[i, j])
                nextMonth[j]++;
            else if (giveCount[i] - takeCount[i] > giveCount[j] - takeCount[j])
                nextMonth[i]++;
            else if (giveCount[j] - takeCount[j] > giveCount[i] - takeCount[i])
                nextMonth[j]++;
        }
    }
    
    return nextMonth.Max();
}
}
