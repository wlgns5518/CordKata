using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        for(char ch = 'a'; ch <= 'z'; ++ch)
        {
            if(s.Split(ch).Length == 2)
            {
                answer += ch;
            }
        }
        return answer;
    }
}