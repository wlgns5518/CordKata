using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        // 크기별 개수 세기
        var dict = new Dictionary<int, int>();
        foreach (var size in tangerine)
        {
            if (dict.ContainsKey(size))
                dict[size]++;
            else
                dict[size] = 1;
        }

        // 개수 내림차순 정렬
        var counts = dict.Values.OrderByDescending(x => x).ToList();

        int kind = 0;
        int sum = 0;
        foreach (var cnt in counts)
        {
            sum += cnt;
            kind++;
            if (sum >= k)
                break;
        }

        return kind;
    }
}