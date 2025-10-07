using System;

public class Solution {
    public string[] solution(string[] picture, int k)
{
    string[] answer = new string[picture.Length * k];
    int index = 0;

    foreach (string s in picture)
    {
        // 가로로 k배 확장
        string expandedRow = "";
        foreach (char ch in s)
        {
            expandedRow += new string(ch, k);
        }

        // 세로로 k배 확장
        for (int i = 0; i < k; i++)
        {
            answer[index++] = expandedRow;
        }
    }

    return answer;
}
}