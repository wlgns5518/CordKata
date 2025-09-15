using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s)
{
    string answer = "";
    char[] chars = new char[my_string.Length];
    for(int i=0;i<my_string.Length;i++)
    {
        chars[i] = my_string[i];
    }
    for(int i=0;i<overwrite_string.Length;i++)
    {
        chars[i+s] = overwrite_string[i];
    }
    for(int i=0;i<chars.Length;i++)
    {
        answer += chars[i];
    }
    return answer;
}
}