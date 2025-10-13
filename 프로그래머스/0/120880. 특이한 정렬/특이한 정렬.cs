using System;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        int len = numlist.Length;

        // 버블 정렬
        for (int i = 0; i < len - 1; i++) {
            for (int j = 0; j < len - i - 1; j++) {

                int distA = Math.Abs(numlist[j] - n);
                int distB = Math.Abs(numlist[j + 1] - n);

                // 정렬 조건:
                // 1️⃣ n과의 거리가 더 크면 뒤로
                // 2️⃣ 거리가 같고 더 작은 수면 뒤로
                if (distA > distB || (distA == distB && numlist[j] < numlist[j + 1])) {
                    // swap
                    int temp = numlist[j];
                    numlist[j] = numlist[j + 1];
                    numlist[j + 1] = temp;
                }
            }
        }

        return numlist;
    }
}