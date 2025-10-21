using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        var answer = new List<int>();

        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) {       // i가 n의 인수이면
                answer.Add(i);       // 한 번만 추가
                while (n % i == 0) {
                    n /= i;          // n에서 모든 i 제거
                }
            }
        }

        if (n > 1) answer.Add(n);   // 남은 n이 소수면 추가

        return answer.ToArray();
    }
}
