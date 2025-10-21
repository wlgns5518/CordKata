using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = int.MinValue;
        for(int i=0;i<numbers.Length;i++)
        {
            for(int j=i;j<numbers.Length;j++)
            {
                if(i==j)
                    continue;
                else
                {
                    if(numbers[i]*numbers[j] >answer)
                        answer = numbers[i] * numbers[j];
                }
            }
        }
        return answer;
    }
}