using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        double num = Math.Sqrt(n);
        if(num%1 != 0)
            return 2;
        return answer;
    }
}