using System;

public class Solution {
    public string[] solution(string[] quiz)
{
    string[] answer = new string[quiz.Length];

    for (int i = 0; i < quiz.Length; i++)
    {
        string[] parts = quiz[i].Split(' ');
        int x = int.Parse(parts[0]);
        string op = parts[1];
        int y = int.Parse(parts[2]);
        int z = int.Parse(parts[4]);

        int result = (op == "+") ? x + y : x - y;

        answer[i] = (result == z) ? "O" : "X";
    }

    return answer;
}
}