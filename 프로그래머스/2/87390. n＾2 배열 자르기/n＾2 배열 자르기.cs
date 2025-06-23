using System;

public class Solution {
    public int[] solution(int n, long left, long right)
{
    int length = (int)(right - left + 1);
    int[] answer = new int[length];

    for (long i = left; i <= right; i++)
    {
        long row = i / n;
        long col = i % n;
        answer[i - left] = (int)(Math.Max(row, col) + 1);
    }

    return answer;
}
}