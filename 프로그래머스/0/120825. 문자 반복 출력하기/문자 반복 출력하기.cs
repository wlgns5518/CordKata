using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int n) {
        var answer = new StringBuilder();
        for(int i=0;i<my_string.Length;i++)
        {
            answer.Append(my_string[i],n);
        }
        return answer.ToString();
    }
}