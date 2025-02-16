using System;

public class Solution {
    public string solution(string my_string)
{
    string answer = "";
    char[] chars = new char[my_string.Length];
    for(int i=0;i<my_string.Length;i++)
    {
        if (my_string[i] >= 'a' && my_string[i]<='z')
        {
            chars[i] = my_string[i];
            chars[i] -= ' ';
        }
        else
        {
            chars[i] = my_string[i];
            chars[i] += ' ';
        }
    }
    answer = new string(chars);
    return answer;
}
}