using System;

public class Solution {
    public int solution(string my_string, string is_suffix)
{
    int answer = 0;
    string[] my_stringArray = new string[my_string.Length];
    for (int i = 0; i < my_string.Length; i++)
    {
        my_stringArray[i] = my_string.Substring(i);
    }
    for(int i=0;i<my_string.Length;i++)
    {
        if (my_stringArray[i] == is_suffix)
            answer = 1;
    }

    return answer;
}
}