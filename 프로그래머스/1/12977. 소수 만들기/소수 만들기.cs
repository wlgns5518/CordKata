using System;

class Solution
{
    public int solution(int[] nums)
{
    int answer = 0;
    for(int i=0;i<nums.Length-2;i++)
{
    for(int j=i+1;j<nums.Length-1;j++)
    {
        for(int k=j+1;k<nums.Length;k++)
        {
            if (IsPrime(nums[i] + nums[j] + nums[k]))
                answer++;

        }
    }
}
    return answer;
}
bool IsPrime(int number)
{
    if (number <= 1) return false; // 1 이하의 숫자는 소수가 아님
    if (number <= 3) return true;  // 2와 3은 소수
    if (number % 2 == 0 || number % 3 == 0) return false; // 2 또는 3으로 나누어지면 소수가 아님

    for (int i = 5; i * i <= number; i += 6)
    {
        if (number % i == 0 || number % (i + 2) == 0)
            return false;
    }

    return true;
}
}