using System;

public class Solution {
    public int solution(int num, int k)
{
    int answer = -1;
    int numcnt = 0;
    int x1 = 0;
    int x2 = num;
    for (int i = 0; i < 7; i++)
    {
        x1 = x2 % 10;
        x2 = x2 / 10;
        if (x2 == 0)
        {
            numcnt = i+1;
            break;
        }
    }
    x1 = 0;
    x2 = num;
    int[] ints = new int[numcnt];
    for (int i=numcnt-1;i >=0;i--)
    {
        x1 = x2 % 10;
        x2 = x2 / 10;
        ints[i] = x1;
        if (ints[i]==k)
            answer = i+1;
    }
    return answer;
}
}