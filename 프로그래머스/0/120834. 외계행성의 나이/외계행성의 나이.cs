using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int age) {
        string answer = age.ToString();
        answer = answer.Replace("0", "a");
        answer = answer.Replace("1", "b");
        answer = answer.Replace("2", "c");
        answer = answer.Replace("3", "d");
        answer = answer.Replace("4", "e");
        answer = answer.Replace("5", "f");
        answer = answer.Replace("6", "g");
        answer = answer.Replace("7", "h");
        answer = answer.Replace("8", "i");
        answer = answer.Replace("9", "j");

        return answer;
    }
}