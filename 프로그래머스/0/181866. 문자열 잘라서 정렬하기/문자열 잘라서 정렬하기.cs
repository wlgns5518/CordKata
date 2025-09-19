using System;

public class Solution {
    public string[] solution(string myString)
{
    string[] answer = myString.Split("x", System.StringSplitOptions.RemoveEmptyEntries);
    Array.Sort(answer);
    return answer;
}
}