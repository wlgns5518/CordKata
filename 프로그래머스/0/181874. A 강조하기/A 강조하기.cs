using System;
using System.Text;

public class Solution {
    public string solution(string myString)
{
    var answer = new StringBuilder();
    for (int i = 0; i < myString.Length; i++)
    {
        if (myString[i] == 'a'|| myString[i] == 'A')
            answer.Append('A');
        else
            answer.Append(char.ToLower(myString[i]));
    }
    return answer.ToString();
}
}