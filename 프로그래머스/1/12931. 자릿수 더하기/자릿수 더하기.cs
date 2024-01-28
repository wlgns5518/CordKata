using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int n1 = n%100000000;
        int n2 = n%10000000;
        int n3 = n%1000000;
        int n4 = n%100000;
        int n5 = n%10000;
        int n6 = n%1000;
        int n7 = n%100;
        int n8 = n%10;
        answer = n/100000000 + n1/10000000 + n2/1000000 + n3/100000 + n4/10000
            +n5/1000+n6/100+ n7/10 + n8/1;
        return answer;
    }
}