using System;

public class Solution {
    public int solution(int n) {
        int count =0;
        for(int i=1;i*i<=n;i++)
        {
            if(n%i == 0)
                count+= (i*i == n)?1:2;
        }
        return count;
    }
}