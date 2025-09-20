using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance)
{
    // Where를 사용하지 않고, 출석하지 않은 학생은 키를 매우 크게 만들어 정렬 뒤로 보냄
    var top = Enumerable.Range(0, rank.Length)
                        .OrderBy(i => attendance[i] ? rank[i] : int.MaxValue)
                        .Take(3)
                        .ToArray();

    return top[0] * 10000 + top[1] * 100 + top[2];
}
}