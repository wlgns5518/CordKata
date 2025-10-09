using System;

public class Solution {
    public int solution(int M, int N) {
        int answer = -1;
        for(int i=0;i<M;i++)
        {
            for(int j=0;j<N;j++)
            {
                answer++;
            }
        }
        return answer;
    }
}