using System;

public class Solution {
    public int solution(string A, string B) {
        if (A.Length != B.Length) return -1;

        string rotated = A;
        int n = A.Length;

        for (int i = 0; i < n; i++) {
            if (rotated == B) return i; // 현재 회전 횟수가 최소
            // 오른쪽으로 한 칸 회전
            rotated = rotated[ n - 1 ] + rotated.Substring(0, n - 1);
        }

        return -1; // 어떤 회전으로도 B가 안 되는 경우
    }
}