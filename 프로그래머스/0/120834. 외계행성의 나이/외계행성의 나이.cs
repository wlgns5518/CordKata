using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        while(age>0)
        {

            answer=(char)(age%10+97)+answer;
            age/=10;
        }
        return answer;
    }
}