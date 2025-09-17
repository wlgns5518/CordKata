using System;

public class Solution {
     public string solution(string my_string, int m, int c)
{
    string answer = "";
    for (int i = 0; i < my_string.Length / m; i++)
    {
        answer += my_string.Substring(i*m, m)[c-1];
    }
    return answer;
}
}