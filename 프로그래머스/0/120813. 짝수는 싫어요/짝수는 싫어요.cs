using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        var answer = new List<int>(n/2);
        for(int i=1;i<=n;i++)
        {
            if(i%2 != 0)
                answer.Add(i);
        }
        return answer.ToArray();
    }
}