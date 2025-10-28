using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int lcm = LCM(denom1,denom2);
        int factor1 = lcm/denom1;
        int factor2 = lcm/denom2;
        answer[0] = factor1 * numer1 + factor2 * numer2;
        answer[1] = lcm;
        int gcd = GCD(answer[0], answer[1]);
answer[0] /= gcd;
answer[1] /= gcd;
        return answer;
    }
    int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    int LCM(int a, int b)
    {
        return a / GCD(a, b) * b;
    }
}