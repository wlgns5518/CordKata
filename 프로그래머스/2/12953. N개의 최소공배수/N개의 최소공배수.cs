public class Solution {
    public int solution(int[] arr)
{
    int lcm = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        lcm = LCM(lcm, arr[i]);
    }
    return lcm;
}

private int LCM(int a, int b)
{
    return a * b / GCD(a, b);
}

private int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
}