using System;

public class Solution {
    public int solution(int n) {
        int pizza = LCM(n,6);
        return pizza/6;
    }
    int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
    int LCM(int a, int b)
{
    return a / GCD(a, b) * b;  // a*b를 바로 하면 오버플로우 가능
}

}