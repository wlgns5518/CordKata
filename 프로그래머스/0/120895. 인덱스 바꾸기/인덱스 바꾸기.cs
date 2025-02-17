using System;

public class Solution {
    public string solution(string my_string, int num1, int num2)
{
    string answer = "";
    char[] chars= new char[my_string.Length];  
    for(int i=0;i<my_string.Length;i++)
    {
        if (i == num1)
            chars[i] = my_string[num2];
        else if (i == num2)
            chars[i] = my_string[num1];
        else
            chars[i] = my_string[i];

    }
    answer  = new string(chars);
    return answer;
}
}