using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        while(n != 1)
        {
            if(n%2==0)
            {
                answer.Add(n);
                n/=2;
            }
                
            else
            {
                answer.Add(n);
                n=3*n+1;
            }     
        }
        answer.Add(n);
        return answer.ToArray();
    }
}