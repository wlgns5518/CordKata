using System;
public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[] { -1 };
        int cnt = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                cnt++;
            }
        }
        if (cnt > 0)
        {
            answer = new int[cnt];
        }
        cnt = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                answer[cnt] = arr[i];
                cnt++;
            }
        }
        Array.Sort(answer);
        return answer;
    }
}