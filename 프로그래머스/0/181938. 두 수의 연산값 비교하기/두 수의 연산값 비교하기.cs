using System;

public class Solution {
    public int solution(int a, int b)
{
    int num1 = int.Parse($"{a}{b}");
    int num2 = 2 * a * b;
    return Math.Max(num1, num2);
}
}