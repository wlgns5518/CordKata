using System;

public class Solution
{
    public int solution(int balls, int share)
    {
        return (int)combination(balls, share);
    }
    public long combination(int num1, int num2)
    {
        long result = 1;
        if (num1 / 2 < num2)
            num2 = num1 - num2;
        for (int i = 1; i <= num2; i++)
        {
            result *= (num1 - i + 1);
            result /= i;
        }
        return result;
    }
}