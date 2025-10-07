using System;
using System.Text;

public class Solution {
    public string[] solution(string[] picture, int k)
{
    string[] answer = new string[picture.Length * k];
    int index = 0;
    var expandedRow = new StringBuilder();
    foreach (string s in picture)
    {
        // 가로로 k배 확장
        expandedRow.Clear();
        foreach (char ch in s)
        {
            expandedRow.Append(ch, k);
        }

        // 세로로 k배 확장
        for (int i = 0; i < k; i++)
        {
            answer[index++] = expandedRow.ToString();
        }
    }

    return answer;
}
}