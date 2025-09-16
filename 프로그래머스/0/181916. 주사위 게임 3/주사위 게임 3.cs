using System;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int[] dice = { a, b, c, d };
        Array.Sort(dice);
        int x1 = dice[0], x2 = dice[1], x3 = dice[2], x4 = dice[3];

        if (x1 == x4) // 모두 같음
            return 1111 * x1;
        else if (x1 == x3) // 앞 3개 같음
            return (int)Math.Pow(10 * x1 + x4, 2);
        else if (x2 == x4) // 뒤 3개 같음
            return (int)Math.Pow(10 * x4 + x1, 2);
        else if (x1 == x2 && x3 == x4) // 2+2
            return (x1 + x3) * Math.Abs(x1 - x3);
        else if (x1 == x2) // 앞 2개 같음
            return x3 * x4;
        else if (x2 == x3) // 가운데 2개 같음
            return x1 * x4;
        else if (x3 == x4) // 뒤 2개 같음
            return x1 * x2;
        else // 전부 다름
            return x1;
    }
}