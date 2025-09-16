using System;

public class Solution {
    public int solution(string number)
{
    int numSum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        numSum += (int)(number[i]-'0');
    }
    return numSum % 9;
}
}