using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(char c in my_string)
        {
            switch(c)
            {
                case 'a':
                    break;
                case 'e':
                    break;
                case 'i':
                    break;
                case 'o':
                    break;
                case 'u':   
                    break;
                default:
                    answer += c;
                    break;
            }
        }
        return answer;
    }
}