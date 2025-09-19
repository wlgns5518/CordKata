using System;
using System.Text;

public class Solution {
    public string solution(string rny_string)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in rny_string)
        {
            if (c == 'm')
                sb.Append("rn"); // 'm'이면 "rn" 추가
            else
                sb.Append(c); // 나머지는 그대로 추가
        }

        return sb.ToString();
    }
}