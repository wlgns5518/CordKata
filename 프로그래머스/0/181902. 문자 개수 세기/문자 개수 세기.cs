using System;

public class Solution {
    public int[] solution(string my_string)
{
    int[] answer = new int[52];
    for (int i = 0; i < my_string.Length; i++)
    {
        if (my_string[i] >= 'A' && my_string[i] <= 'Z')
            answer[my_string[i] - 'A']++;
        else
            answer[my_string[i] - 'a'+26]++;
    }
    return answer;
}
}