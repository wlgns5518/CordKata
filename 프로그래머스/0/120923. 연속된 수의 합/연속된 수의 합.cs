using System;

public class Solution {
        public int[] solution(int num, int total)
{
    int middleNum = 0;
    if ((total % num)!=0)
        middleNum = total / num + 1;
    else
        middleNum = total / num;
    int[] answer = new int[num];
    for(int i=0;i< num;i++)
    {
        answer[i] = middleNum - num / 2 + i;
    }
    return answer;
}
}