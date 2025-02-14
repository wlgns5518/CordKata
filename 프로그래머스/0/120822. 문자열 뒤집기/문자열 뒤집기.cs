using System;

public class Solution {
    public string solution(string my_string)
{
    string answer = "";
    char[] chars = my_string.ToCharArray();
    for(int i=0; i<my_string.Length;i++)
    {
        chars[my_string.Length-i-1] = my_string[i];
    }
    answer = string.Concat(chars);
    return answer;
}
}