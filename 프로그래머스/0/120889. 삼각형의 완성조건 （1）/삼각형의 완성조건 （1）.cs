using System;

public class Solution
{
    public int solution(int[] sides)
    {
        int a = sides[0];
        int b = sides[1];
        int c = sides[2];

        // 최대값 찾기
        int max = Math.Max(a, Math.Max(b, c));

        // 나머지 두 변의 합
        int sumOther = a + b + c - max;

        return max < sumOther ? 1 : 2;
    }
}