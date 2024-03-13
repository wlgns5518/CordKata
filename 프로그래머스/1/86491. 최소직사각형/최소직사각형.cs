using System;

public class Solution {
    public int solution(int[,] sizes) {
        int max1 = 0;
        int max2 = 0;
        for (int i = 0; i < sizes.GetLength(0); i++) {
            max1 = Math.Max(max1, Math.Max(sizes[i, 0], sizes[i, 1]));
            max2 = Math.Max(max2, Math.Min(sizes[i, 0], sizes[i, 1]));
        }

        int answer = max1 * max2;
        return answer;
    }
}