using System;
using System.Collections.Generic;


public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums)
{
    if (lottos == null || win_nums == null)
        return new int[] { 6, 6 };

    var winSet = new HashSet<int>(win_nums);
    int zeroCount = 0;
    int matchCount = 0;

    foreach (var n in lottos)
    {
        if (n == 0)
        {
            zeroCount++;
            continue;
        }

        if (winSet.Contains(n))
            matchCount++;
    }

    int bestRank = Math.Min(7 - (matchCount + zeroCount), 6);
    int worstRank = Math.Min(7 - matchCount, 6);

    return new[] { bestRank, worstRank };
}
}