using System;

public class Solution {
    public int solution(int[] numbers, int k)
{
    int count = 0;
    for (int i = 0; i < k * 2; i += 2)
    {
        count = i % numbers.Length;
    }
    return numbers[count];
}
}