using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        long remain = n;
        long[] arr  = new long[n.ToString().Length];
        for(int i =0; i<n.ToString().Length; i++)
        {
            arr[i] = remain % 10;
            remain /= 10;
        }
        Array.Sort(arr);
        for (int i = 0; i < n.ToString().Length; i++)
        {
            answer += arr[i] * (long)MathF.Pow(10, i);
        }
        return answer;
    }
}