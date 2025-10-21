using System;

public class Solution {
    public int solution(int a, int b) {
        int n = GCD(a,b);
        a = a/n;
        b = b/n;
        while(b != 1)
        {
            if(b%2 == 0)
                b/=2;
            else if(b% 5 == 0)
                b/=5;
            else
                return 2;
        }
        return 1;
    }
    public int GCD(int a,int b)
    {
        int temp = 0;
        while(b != 0)
        {
            temp = a%b;
            a = b;
            b = temp;
        }
        return a;
    }
}