using System;

public class Solution {
    public string[] solution(string my_str, int n)
{
    // 마지막 조각까지 포함하도록 배열 길이 계산
    int length = (my_str.Length + n - 1) / n;
    string[] answer = new string[length];
    
    for (int i = 0; i < length; i++)
    {
        // 마지막 조각 길이 조정
        int substringLength = Math.Min(n, my_str.Length - i * n);
        answer[i] = my_str.Substring(i * n, substringLength);
    }
    
    return answer;
}
}