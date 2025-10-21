using System;
using System.Text.RegularExpressions;

public class Solution
{
    public int solution(string my_string)
    {
        // 숫자가 아닌 문자를 모두 공백으로 치환
        string replaced = Regex.Replace(my_string, @"[^\d]", " ");
        
        int sum = 0;
        // 공백으로 split 후 숫자가 있는 경우 합산
        foreach (string s in replaced.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            sum += int.Parse(s);
        }

        return sum;
    }
}