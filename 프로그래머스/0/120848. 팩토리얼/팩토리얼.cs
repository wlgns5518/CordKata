using System;

public class Solution {
    public int solution(int n)
{
    int answer = 0;
    int num = 1;
    while(n>=num)
    {
        answer++;
        num *= answer + 1;
    }
    return answer;
}
}