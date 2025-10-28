using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int lcm = denom1 / GCD(denom1, denom2) * denom2;  // 공통 분모
        int sumNumerator = numer1 * (lcm / denom1) + numer2 * (lcm / denom2);
        int gcd = GCD(sumNumerator, lcm);                  // 약분
        return new int[] { sumNumerator / gcd, lcm / gcd };
    }

    int GCD(int a, int b) {
        while (b != 0) { int t = b; b = a % b; a = t; }
        return a;
    }
}
