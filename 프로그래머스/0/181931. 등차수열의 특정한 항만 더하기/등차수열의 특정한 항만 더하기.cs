using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;
        for(int i=0;i<included.Length;i++)
        {
            if(included[i] == true)
            {
                answer += i*d+a;
            }
        }
        return answer;
    }
}