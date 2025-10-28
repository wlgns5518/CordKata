using System;

public class Solution
{
    public string solution(int age)
    {
        string answer = "";
        string agestr = age.ToString();
        for (int i = 0; i < agestr.Length; i++)
        {
            answer += (char)(agestr[i] + 49);
        }
        return answer;
    }
}