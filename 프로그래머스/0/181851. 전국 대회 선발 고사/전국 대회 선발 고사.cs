using System;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int n = rank.Length;
        // (등수, 번호) 쌍 저장
        int[,] students = new int[n, 2];
        int count = 0;

        for (int i = 0; i < n; i++) {
            if (attendance[i]) {
                students[count, 0] = rank[i]; // 등수
                students[count, 1] = i;       // 학생 번호
                count++;
            }
        }

        // 단순 정렬 (버블 정렬 또는 선택 정렬)
        for (int i = 0; i < count - 1; i++) {
            for (int j = i + 1; j < count; j++) {
                if (students[i, 0] > students[j, 0]) {
                    // swap (등수, 번호) 같이 바꿔주기
                    int tmpRank = students[i, 0];
                    int tmpIdx  = students[i, 1];
                    students[i, 0] = students[j, 0];
                    students[i, 1] = students[j, 1];
                    students[j, 0] = tmpRank;
                    students[j, 1] = tmpIdx;
                }
            }
        }

        // 상위 3명 학생 번호
        int a = students[0, 1];
        int b = students[1, 1];
        int c = students[2, 1];

        return 10000 * a + 100 * b + c;
    }
}