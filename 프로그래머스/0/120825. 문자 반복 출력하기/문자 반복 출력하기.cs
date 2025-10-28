using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int n) {
        var answer = new StringBuilder();
        for(int i=0;i<my_string.Length;i++)
        {
            for(int j=0;j<n;j++)
                answer.Append(my_string[i]);
        }
        return answer.ToString();
    }
}