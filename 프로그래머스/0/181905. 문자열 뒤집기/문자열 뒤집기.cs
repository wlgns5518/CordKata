using System;

public class Solution {
    public string solution(string my_string, int s, int e)
{
    string answer = "";
    int count = 0;
    for (int i = 0; i < my_string.Length; i++)
    {
        if (i >= s && i <= e)
        {
            answer += my_string[e - count];
            count++;
        }
        else
            answer += my_string[i];
    }
    return answer;
}
}