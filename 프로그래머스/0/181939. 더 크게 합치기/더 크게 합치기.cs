using System;

public class Solution {
    public int solution(int a, int b)
{
    int answer = 0;
    string answerstr;
    string answerstr2;
    answerstr = a.ToString() + b.ToString();
    answerstr2 = b.ToString() + a.ToString();
    if (int.Parse(answerstr) > int.Parse(answerstr2))
        answer = int.Parse(answerstr);
    else
        answer = int.Parse(answerstr2);
    return answer;
}
}