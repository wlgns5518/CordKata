using System;

public class Solution {
    public string solution(string my_string)
{
    string answer = "";
    char[] chars = my_string.ToLower().ToCharArray();
    Array.Sort(chars);
    answer = new string(chars); 
    return answer;
}
}