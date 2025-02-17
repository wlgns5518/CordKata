using System;

public class Solution {
    public int solution(int num, int k)
{
    int answer = -1;
    int numcnt = 0;
    int x1 = num;
    for (int i = 0; i < 7; i++)
    {
        x1 = x1 / 10;
        if (x1 == 0)
        {
            numcnt = i+1;
            break;
        }
    }
    x1 = num;
    int[] ints = new int[numcnt];
    for (int i=numcnt-1;i >=0;i--)
    {
        ints[i] = x1%10;
        x1 = x1 / 10;
        if (ints[i]==k)
            answer = i+1;
    }
    return answer;
}
}
