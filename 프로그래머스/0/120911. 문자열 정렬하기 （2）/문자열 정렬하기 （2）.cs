using System;

public class Solution {
    public string solution(string my_string)
{
    string answer = "";
    char[] chars= new char[my_string.Length];
    my_string = my_string.ToLower();
    for(int i=0;i<my_string.Length;i++)
    {
        chars[i] = my_string[i];
    }
    for (int i = 0; i < chars.Length; i++)
    {
        for(int j=0;j<chars.Length;j++)
        {
            if (chars[i] < chars[j])
            {
                char index = chars[i];
                chars[i] = chars[j];
                chars[j] = index;
            }
        }
    }
    answer = new string(chars); 
    return answer;
}
}