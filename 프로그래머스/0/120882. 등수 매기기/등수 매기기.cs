using System;
using System.Linq;

public class Solution {
    public int[] solution(int[,] score) {
        int n = score.GetLength(0);
        int[] avg = new int[n];
        int[] rank = new int[n];
        
        // 평균 계산
        for (int i = 0; i < n; i++) {
            avg[i] = score[i, 0] + score[i, 1];
        }

        // 등수 계산
        for (int i = 0; i < n; i++) {
            rank[i] = 1; // 기본 등수는 1등
            for (int j = 0; j < n; j++) {
                if (avg[j] > avg[i]) {
                    rank[i]++;
                }
            }
        }

        return rank;
    }
}
