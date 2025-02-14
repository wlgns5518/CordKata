using System;

public class Solution {
    public int solution(int[] numbers)
{
    int answer = 0;
    int maxNum = 0;
    int secNum = 0;
    for(int i=0;i<numbers.Length;i++)
    {
        if (secNum < numbers[i])
        {
            if (maxNum < numbers[i])
            {
                secNum = maxNum;
                maxNum = numbers[i];
            }
            else
                secNum = numbers[i];
        }
    }
    answer = maxNum * secNum;
    return answer;
}
}