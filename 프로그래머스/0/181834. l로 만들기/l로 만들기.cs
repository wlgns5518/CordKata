using System;
using System.Text;

public class Solution {
    public string solution(string myString) {
        var answer = new StringBuilder();
        for(int i=0;i<myString.Length;i++)
        {
            if(myString[i]<'l')
                answer.Append('l');
            else
                answer.Append(myString[i]);
        }
        
        return answer.ToString();
    }
}