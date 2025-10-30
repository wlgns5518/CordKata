using System;

public class Solution {
    public int solution(int[,] info, int n, int m) {
        int items = info.GetLength(0); // 물건 개수
        bool[,] dp = new bool[n, m];
        dp[0, 0] = true;

        for (int i = 0; i < items; i++) {
            bool[,] next = new bool[n, m];
            int addA = info[i, 0];
            int addB = info[i, 1];

            for (int a = 0; a < n; a++) {
                for (int b = 0; b < m; b++) {
                    if (!dp[a, b]) continue;

                    // A가 훔치는 경우
                    int na = a + addA;
                    if (na < n) next[na, b] = true;

                    // B가 훔치는 경우
                    int nb = b + addB;
                    if (nb < m) next[a, nb] = true;
                }
            }

            dp = next;
        }

        // 가능한 최소 A의 흔적합 찾기
        for (int a = 0; a < n; a++) {
            for (int b = 0; b < m; b++) {
                if (dp[a, b]) return a;
            }
        }

        return -1; // 불가능한 경우
    }
}
