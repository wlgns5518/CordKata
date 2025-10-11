using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        var answer = new List<int>();
        for(int i=1;i<=n;i++)
        {
            if(n%i == 0)
                answer.Add(i);
        }
        return answer.ToArray();
    }
}