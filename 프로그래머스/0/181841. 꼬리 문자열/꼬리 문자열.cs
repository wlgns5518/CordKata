using System;
using System.Text;

public class Solution {
    public string solution(string[] str_list, string ex)
{
    var answer = new StringBuilder();
    for (int i = 0; i < str_list.Length; i++)
    {
        if (str_list[i].Contains(ex))
            continue;
        answer.Append(str_list[i]);
    }
    return answer.ToString();
}
}