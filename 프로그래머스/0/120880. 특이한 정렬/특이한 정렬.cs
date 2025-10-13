using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        return numlist
            .OrderBy(x => Math.Abs(x - n))   // n과의 거리 기준 오름차순 정렬
            .ThenByDescending(x => x)        // 거리가 같다면 큰 수가 앞에 오도록 정렬
            .ToArray();
    }
}
