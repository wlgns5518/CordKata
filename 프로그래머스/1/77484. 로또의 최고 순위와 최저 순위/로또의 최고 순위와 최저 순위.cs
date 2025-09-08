using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums)
{
    int[] answer = new int[2];
    int zeroCount = 0;
    int correctCount = 0;
    for(int i=0;i<6;i++)
    {
        if (lottos[i] == 0)
        {
            zeroCount++;
            continue;
        }
        for (int j=0;j<6;j++)
        {
            if(lottos[i] == win_nums[j])
            {
                correctCount++;
                break;
            }
        }
    }
    answer[1] = 7 - correctCount;
    if (answer[1] >6)
    {
        answer[1] = 6;
    }
    answer[0] = 7 - correctCount - zeroCount;
    if (answer[0] > 6)
    {
        answer[0] = 6;
    }
    return answer;
}
}