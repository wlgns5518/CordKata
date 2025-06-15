using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        // 크기별 개수 세기
        var dict = new Dictionary<int, int>();
        foreach (var size in tangerine)
        {
            if (dict.TryGetValue(size, out int cnt))
                dict[size] = cnt + 1;
            else
                dict[size] = 1;
        }

        // Value만 배열로 추출 후 내림차순 정렬
        int[] counts = new int[dict.Count];
        int idx = 0;
        foreach (var v in dict.Values)
            counts[idx++] = v;
        Array.Sort(counts, (a, b) => b.CompareTo(a)); // 내림차순

        int kind = 0, sum = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            sum += counts[i];
            kind++;
            if (sum >= k)
                break;
        }
        return kind;
    }
}