using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
         int[] pattern1 = {1, 2, 3, 4, 5};
        int[] pattern2 = {2, 1, 2, 3, 2, 4, 2, 5};
        int[] pattern3 = {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        // 각 수포자의 정답 수를 카운트할 배열 초기화
        int[] score = new int[3];
        
        // 정답 확인 및 점수 부여
        for (int i = 0; i < answers.Length; i++) {
            if (answers[i] == pattern1[i % pattern1.Length]) {
                score[0]++;
            }
            if (answers[i] == pattern2[i % pattern2.Length]) {
                score[1]++;
            }
            if (answers[i] == pattern3[i % pattern3.Length]) {
                score[2]++;
            }
        }
        
        // 최고 점수 계산
        int maxScore = Math.Max(score[0], Math.Max(score[1], score[2]));
        
        // 최고 점수를 받은 수포자들 찾기
        List<int> winners = new List<int>();
        for (int i = 0; i < score.Length; i++) {
            if (score[i] == maxScore) {
                winners.Add(i + 1);
            }
        }
        
        return winners.ToArray();
    }
}