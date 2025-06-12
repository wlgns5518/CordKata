using System;

class Solution
{
   public int solution(int n, int a, int b)
{
    int answer = 0;
    int aRemain = 0;
    int bRemain= 0;
    int aShare = 0;
    int bShare = 0;
    while(n !=1)
    {
        answer++;
        if (a % 2 == 1 && a + 1 == b)
        {
            return answer;
        }
        else if (b % 2 == 1 && b + 1 == a)
        {
            return answer;
        }
        aRemain = a % 2;
        bRemain = b % 2;
        aShare = a / 2;
        bShare = b / 2;
        a = aRemain + aShare;
        b = bRemain + bShare;
        n = n / 2;
        
    }
    return answer;
}
}